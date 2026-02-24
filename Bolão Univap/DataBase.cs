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

namespace Bolão_Univap
{
    internal class DataBase
    {

        public static MySqlConnection Conexao;
        public static MySqlCommand Comandos;
        public static MySqlDataAdapter Adapter;
        public static ArrayParticipantes Ap = new ArrayParticipantes();

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

        //-------------------------Comando de adicionar Participante-------------------------
        public Boolean AdicionarParticipante(string nome, string time)
        {
            bool result;
            try
            {
                string comando = $"INSERT INTO participantes (nome, time, pontos, acertosExatos, acertosClassicos, precisaoAcertos, Num_palpites, Num_acertos) VALUES('{nome}','{time}', 0, 0, 0, 0, 0, 0)";
                result = Add_deletar_alterar(comando); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
                result = false;
            }
            finally
            {
                Desconectar();
            }
            return result;
        }

        public static void RemoverPcipante(string nome)
        {

        }

        //-------------------------Executa o comando de inserir e deletar-------------------------
        public Boolean Add_deletar_alterar(string comando)
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
                MessageBox.Show("Ocorreu um erro " + ex.Message);
                result = false;
            }
            finally
            {
                Desconectar();
            }
            return result;
        }

        //-------------------------Coleta os Participantes-------------------------
        public static void ColetarParticipantes() 
        {
            try
            {
                Conectar();
                Comandos = new MySqlCommand($"SELECT id, nome, pontos, acertosExatos, acertosClassicos, precisaoAcertos, Num_palpites, Num_acertos FROM participantes ORDER BY pontos desc, acertosExatos desc, acertosClassicos desc, precisaoAcertos desc", Conexao);

                MySqlDataReader reader = Comandos.ExecuteReader();
                while (reader.Read())
                {
                    Ap.setArrayParticipantes(reader.GetString("id"), reader.GetString("nome"), reader.GetString("pontos"), reader.GetString("acertosExatos"), reader.GetString("acertosClassicos"), reader.GetString("precisaoAcertos"), reader.GetString("Num_palpites"), reader.GetString("Num_acertos"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public string ColetarUltimaRodada()
        {
            string Num_rodada;
            try
            {
                string comando = ($"SELECT MAX(id) as maxId FROM Rodadas");
                Num_rodada = ExecutarSelect(comando, "id");
            }
            catch(Exception ex) 
            { 
                MessageBox.Show (ex.Message);
                Num_rodada = "";
            }
            return Num_rodada;
        }

        public string ExecutarSelect(string comando, string sobrecarga)
        {
            string result;
            try
            {
                Conectar();
                Comandos = new MySqlCommand(comando, Conexao);
                MySqlDataReader reader = Comandos.ExecuteReader();
                reader.Read();
                result = reader.GetString(sobrecarga);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = "";
            }
            finally
            {
                Desconectar();
            }
            return result;
        }

        //-------------------------Fecha a conexão com o banco de dados-------------------------
        public static void Desconectar()
        {
            Conexao.Close();
        }
    }
}
