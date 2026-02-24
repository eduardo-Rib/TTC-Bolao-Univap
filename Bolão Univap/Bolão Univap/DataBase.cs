using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.X509.Qualified;
using MySqlX.XDevAPI.Relational;
using System.Runtime.Intrinsics.Arm;
using MySqlX.XDevAPI.Common;

namespace Bolão_Univap
{
    internal class DataBase
    {

        public static MySqlConnection Conexao;
        public static MySqlCommand Comandos;
        public static MySqlDataAdapter dataAdapter;

        //-------------------------Conecta com o bando de dados-------------------------
        public static void Conectar()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost; user=root; password=; database=BolaoUnivap;");
                Conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }


        //-------------------------Fecha a conexão com o banco de dados-------------------------
        public static void Desconectar()
        {
            Conexao.Close();
        }


        //-------------------------Coleta os Participantes-------------------------

        public static DataTable Consultas(string comando)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                using (var cmd = Conexao.CreateCommand()) {
                    cmd.CommandText = comando;
                    dataAdapter = new MySqlDataAdapter(cmd.CommandText, Conexao);
                    dataAdapter.Fill(dt);
                    Desconectar();
                }
            }
            catch (Exception ex) 
            {
                Desconectar();
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        //-------------------------Executa o comando de inserir, deletar e alterar-------------------------
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
                MessageBox.Show(ex.Message);
                result = false;
            }
            finally
            {
                Desconectar();
            }
            return result;
        }
    }
}
