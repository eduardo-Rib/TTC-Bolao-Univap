using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BolaoUnivap.Database
{
    internal class DataBase
    {

        public static MySqlConnection Conexao;
        public static MySqlCommand Comandos;
        public static MySqlDataAdapter dataAdapter;

        // conexão SEM banco (usada para criar o banco)
        private static string ServerConnectionString =
            "server=localhost;user=root;port=3366;password=P$f130;";

        // conexão COM banco (uso normal)
        private static string DatabaseConnectionString =
            "server=localhost;user=root;port=3366;password=P$f130;database=BolaoUnivap;";



        //-------------------------Conecta direto no servidor (sem banco)-------------------------
        public static void ConectarServidor()
        {
            try
            {
                if (Conexao == null)
                {
                    Conexao = new MySqlConnection(ServerConnectionString);
                }

                if (Conexao.State != ConnectionState.Open)
                {
                    Conexao.ConnectionString = ServerConnectionString;
                    Conexao.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no servidor MySQL: " + ex.Message);
            }
        }



        //-------------------------Conecta no banco-------------------------
        public static void Conectar()
        {
            try
            {
                if (Conexao == null)
                {
                    Conexao = new MySqlConnection(DatabaseConnectionString);
                }

                if (Conexao.State != ConnectionState.Open)
                {
                    Conexao.ConnectionString = DatabaseConnectionString;
                    Conexao.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message);
            }
        }



        //-------------------------Fecha conexão-------------------------
        public static void Desconectar()
        {
            try
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar conexão: " + ex.Message);
            }
        }



        //-------------------------Executa SELECT-------------------------
        public static DataTable Consultas(string comando)
        {
            DataTable dt = new DataTable();

            try
            {
                Conectar();

                using (var cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = comando;

                    dataAdapter = new MySqlDataAdapter(cmd);
                    dataAdapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na consulta: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return dt;
        }



        //-------------------------Executa INSERT/UPDATE/DELETE-------------------------
        public static Boolean Add_deletar_alterar(string comando)
        {
            bool result;

            try
            {
                Conectar();

                Comandos = new MySqlCommand(comando, Conexao);
                Comandos.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando: " + ex.Message);
                result = false;
            }
            finally
            {
                Desconectar();
            }

            return result;
        }



        //-------------------------Executa comando sem abrir conexão-------------------------
        public static void ExecuteSemConectar(string comando)
        {
            Comandos = new MySqlCommand(comando, Conexao);
            Comandos.ExecuteNonQuery();
        }

    }
}