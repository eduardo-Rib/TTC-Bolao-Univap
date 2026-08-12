using BolaoUnivap.Database;

namespace BolaoUnivap
{
    internal class _001_CreateTables : IMigration
    {
        public string Name => "001_CreateTables";

        public void Up()
        {

            string temporadas = @"CREATE TABLE IF NOT EXISTS temporadas (
                id_temp INT AUTO_INCREMENT PRIMARY KEY,
                ano INT NOT NULL,
                status BOOLEAN NOT NULL
            );";

            string rodadas = @"CREATE TABLE IF NOT EXISTS rodadas (
                id_rodada INT AUTO_INCREMENT PRIMARY KEY,
                id_temp INT NOT NULL,
                status BOOLEAN NOT NULL,
                FOREIGN KEY (id_temp) REFERENCES temporadas(id_temp)
            );";

            string jogos = @"CREATE TABLE IF NOT EXISTS jogos (
                id_jogo INT AUTO_INCREMENT PRIMARY KEY,
                id_rodada INT NOT NULL,
                time1 VARCHAR(100) NOT NULL,
                time2 VARCHAR(100) NOT NULL,
                gols_time1 INT NULL,
                gols_time2 INT NULL,
                bonus INT NOT NULL,
                horario DATETIME NOT NULL,
                status BOOLEAN NOT NULL,
                FOREIGN KEY (id_rodada) REFERENCES rodadas(id_rodada)
            );";

            string participantes = @"CREATE TABLE IF NOT EXISTS participantes (
                id_participante INT AUTO_INCREMENT PRIMARY KEY,
                nome VARCHAR(100) NOT NULL
            );";

            string times = @"CREATE TABLE times (
                id_time INT AUTO_INCREMENT PRIMARY KEY,
                nome VARCHAR(100) NOT NULL,
                status BOOLEAN NOT NULL
            );";

            string times_participantes = @"CREATE TABLE times_participantes (
                id_participante INT AUTO_INCREMENT PRIMARY KEY,
	            id_time INT NOT NULL,
	            FOREIGN KEY (id_participante) REFERENCES participantes(id_participante),
	            FOREIGN KEY (id_time) REFERENCES times(id_time)
            );";

            string times_temp = @"CREATE TABLE times_temp (
                id_temp INT AUTO_INCREMENT PRIMARY KEY,
	            id_time INT NOT NULL,
	            FOREIGN KEY (id_temp) REFERENCES temporadas(id_temp),
	            FOREIGN KEY (id_time) REFERENCES times(id_time)
            );";

            string palpites = @"CREATE TABLE IF NOT EXISTS palpites (
                id_palpite INT AUTO_INCREMENT PRIMARY KEY,
                id_participante INT NOT NULL,
                id_jogo INT NOT NULL,
                time_vencedor INT NOT NULL,
                gols_time1 INT NOT NULL,
                gols_time2 INT NOT NULL,
                FOREIGN KEY (id_participante) REFERENCES participantes(id_participante),
                FOREIGN KEY (id_jogo) REFERENCES jogos(id_jogo)
            );";

            string administradores = @"CREATE TABLE IF NOT EXISTS administradores (
                id INT AUTO_INCREMENT PRIMARY KEY,
                email VARCHAR(150) NOT NULL,
                senha VARCHAR(150) NOT NULL
            );";

            DataBase.Add_deletar_alterar(temporadas);
            DataBase.Add_deletar_alterar(rodadas);
            DataBase.Add_deletar_alterar(jogos);
            DataBase.Add_deletar_alterar(participantes);
            DataBase.Add_deletar_alterar(times);
            DataBase.Add_deletar_alterar(times_participantes);
            DataBase.Add_deletar_alterar(times_temp);
            DataBase.Add_deletar_alterar(palpites);
            DataBase.Add_deletar_alterar(administradores);
        }
    }
}