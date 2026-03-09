using Bolão_Univap.Database;
using MySql.Data.MySqlClient;

namespace Bolão_Univap
{
    internal class _001_CreateTables : IMigration
    {
        public string Name => "001_CreateTables";

        public void Up()
        {

            string rodadas = @"CREATE TABLE IF NOT EXISTS rodadas (
                id INT AUTO_INCREMENT PRIMARY KEY,
                status BOOLEAN NOT NULL
            );";

            string jogos = @"CREATE TABLE IF NOT EXISTS jogos (
                id INT AUTO_INCREMENT PRIMARY KEY,
                id_Rodada INT NOT NULL,
                time1 VARCHAR(100) NOT NULL,
                time2 VARCHAR(100) NOT NULL,
                bonus INT NOT NULL,
                horario DATETIME NOT NULL,
                status BOOLEAN NOT NULL,
                FOREIGN KEY (id_Rodada) REFERENCES rodadas(id)
            );";

            string participantes = @"CREATE TABLE IF NOT EXISTS participantes (
                id INT AUTO_INCREMENT PRIMARY KEY,
                nome VARCHAR(100) NOT NULL,
                time VARCHAR(100) NOT NULL,
                pontos INT NOT NULL,
                acertosExatos INT NOT NULL,
                acertosClassicos INT NOT NULL,
                precisaoAcertos FLOAT NOT NULL,
                Num_palpites INT NOT NULL,
                Num_acertos INT NOT NULL
            );";

            string palpites = @"CREATE TABLE IF NOT EXISTS palpites (
                id_palpite INT AUTO_INCREMENT PRIMARY KEY,
                id_participante INT NOT NULL,
                id_jogo INT NOT NULL,
                id_Rodada INT NOT NULL,
                time_vencedor INT NOT NULL,
                gols_time1 INT NOT NULL,
                gols_time2 INT NOT NULL,
                FOREIGN KEY (id_participante) REFERENCES participantes(id),
                FOREIGN KEY (id_jogo) REFERENCES jogos(id),
                FOREIGN KEY (id_Rodada) REFERENCES rodadas(id)
            );";

            string administradores = @"CREATE TABLE IF NOT EXISTS administradores (
                id INT AUTO_INCREMENT PRIMARY KEY,
                email VARCHAR(150) NOT NULL,
                senha VARCHAR(150) NOT NULL
            );";

            DataBase.Add_deletar_alterar(rodadas);
            DataBase.Add_deletar_alterar(jogos);
            DataBase.Add_deletar_alterar(participantes);
            DataBase.Add_deletar_alterar(palpites);
            DataBase.Add_deletar_alterar(administradores);
        }
    }
}