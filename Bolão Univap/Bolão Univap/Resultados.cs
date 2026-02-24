using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolão_Univap
{
    public partial class Resultados : Form
    {

        DataTable dt = new DataTable();
        private string[] time1 = new string[100]; //armazena os times 1 dos jogos
        private string[] time2 = new string[100]; //armazena os times 2 dos jogos
        private int[] id = new int[100];
        private DateTime[] data = new DateTime[100];
        private int cont = 0;

        public Resultados()
        {
            InitializeComponent();
        }



        //---------------TODOS OS SET'S---------------
        private void setTime1(string valor, int indice)
        {
            this.time1[indice] = valor;
        }

        private void setTime2(string valor, int indice)
        {
            this.time2[indice] = valor;
        }

        private void setCont(int valor)
        {
            this.cont = getCont() + valor;
        }

        private void setId(int valor, int indice)
        {
            this.id[indice] = valor;
        }

        private void setHorarios(string valor, int indice)
        {
            this.data[indice] = DateTime.Parse(valor);
        }



        //---------------TODOS OS GET'S---------------
        private int getCont()
        {
            return this.cont;
        }

        private string getTime1(int indice)
        {
            return this.time1[indice];
        }

        private string getTime2(int indice)
        {
            return this.time2[indice];
        }

        private int getId(int indice)
        {
            return this.id[indice];
        }

        private DateTime getData(int indice)
        {
            return this.data[indice];
        }


        //--------------- EVENTOS ---------------
        private void Resultados_Load(object sender, EventArgs e)
        {
            getRodadas();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_rodada = comboBox1.Text;
            comboBox2.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            getJogosDaRodada(id_rodada);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = getTime1(comboBox2.SelectedIndex);
            textBox2.Text = getTime2(comboBox2.SelectedIndex);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }



        //---------------ADICIONA ITENS NOS COMBOBOX---------------
        public void AdicionarComboBoxRodadas(int id_rodada)
        {
            comboBox1.Items.Add(id_rodada);
        }

        public void AdicionarComboBoxJogos(int id_jogo)
        {
            comboBox2.Items.Add(id_jogo.ToString());
        }



        //---------------INSTANCIA O BANCO DE DADOS---------------
        public void getRodadas()
        {
            string comando = ($"SELECT id FROM rodadas WHERE status = true");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AdicionarComboBoxRodadas(dt.Rows[i].Field<int>("id"));
            }
        }

        public void getJogosDaRodada(string id_rodada)
        {
            comboBox2.Items.Clear();
            string comando = ($"SELECT id, time1, time2, horario FROM jogos WHERE id_Rodada = {id_rodada} AND status = true ORDER BY id");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AdicionarComboBoxJogos(i + 1);
                setId(dt.Rows[i].Field<int>("id"), i);
                setTime1(dt.Rows[i].Field<string>("time1"), i);
                setTime2(dt.Rows[i].Field<string>("time2"), i);
                setHorarios(dt.Rows[i].Field<string>("horario"), i);
            }
        }

        public Boolean FinalizarRodada()
        {
            Boolean result;
            string comando = ($"SELECT id FROM jogos WHERE id_Rodada = {comboBox1.Text} AND status = true");
            dt = DataBase.Consultas(comando);

            if (dt.Rows.Count > 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }

        public void EncerrarRodada(string id_rodada)
        {
            string comando = ($"UPDATE rodadas SET status = false WHERE id = {id_rodada}");
            Boolean aux = DataBase.Add_deletar_alterar(comando);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                string comando = ($"SELECT id_palpite FROM palpites WHERE id_jogo = {getId(comboBox2.SelectedIndex)}");
                dt = DataBase.Consultas(comando);
                if (dt.Rows.Count > 0)
                {
                    int id_jogo = getId(int.Parse(comboBox2.Text) - 1);
                    int vencedor;
                    int gols_time1 = int.Parse(textBox3.Text);
                    int gols_time2 = int.Parse(textBox4.Text);

                    if (gols_time1 > gols_time2)
                    {
                        vencedor = 1;
                    }
                    else if (gols_time1 < gols_time2)
                    {
                        vencedor = 2;
                    }
                    else
                    {
                        vencedor = 0;
                    }
                    if (AdicionarResultados(id_jogo, gols_time1, gols_time2, vencedor))
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        comboBox2.Text = "";
                        getJogosDaRodada(comboBox1.Text);

                        if (FinalizarRodada() == true)
                        {
                            EncerrarRodada(comboBox1.Text);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Prencha os campos corretamente");
            }
        }



        public static Boolean AdicionarResultados(int id_jogo, int gols1, int gols2, int vencedor_real)
        {
            Boolean result = false;

            int[] id_participantes = new int[100];
            int[] gols_time1 = new int[100];
            int[] gols_time2 = new int[100];
            int[] vencedor = new int[100];
            DataTable dt = new DataTable();


            string comando = ($"SELECT bonus FROM jogos WHERE id = {id_jogo}");
            dt = DataBase.Consultas(comando);
            Boolean bonus = dt.Rows[0].Field<Boolean>("bonus");
            


            comando = ($"SELECT id_participante, time_vencedor, gols_time1, gols_time2 FROM palpites WHERE id_jogo = {id_jogo}");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id_participantes[i] = dt.Rows[i].Field<int>("id_participante");
                vencedor[i] = dt.Rows[i].Field<int>("time_vencedor");
                gols_time1[i] = dt.Rows[i].Field<int>("gols_time1");
                gols_time2[i] = dt.Rows[i].Field<int>("gols_time2");
            }

            DataTable dt2 = new DataTable();

            //MessageBox.Show("Numero de palpites = " + dt.Rows.Count);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int acertosTotais = 0;
                int acertosClassicos = 0;
                int pontos_totais = 0;
                int Npalpites = 0;
                int Nacertos = 0;
                int pontos = 0;


                comando = ($"SELECT pontos, acertosExatos, acertosClassicos, Num_palpites, Num_acertos FROM participantes WHERE id = {id_participantes[i]}");
                dt2 = DataBase.Consultas(comando);

                if (dt2.Rows.Count > 0)
                {
                    pontos_totais = dt2.Rows[0].Field<int>("pontos");
                    acertosTotais = dt2.Rows[0].Field<int>("acertosExatos");
                    acertosClassicos = dt2.Rows[0].Field<int>("acertosClassicos");
                    Npalpites = dt2.Rows[0].Field<int>("Num_palpites");
                    Nacertos = dt2.Rows[0].Field<int>("Num_acertos");
                }



                Npalpites += 1;
                if (vencedor[i] == vencedor_real)
                {
                    Nacertos += 1;
                    pontos += 5;
                    if (gols_time1[i] == gols1 && gols_time2[i] == gols2)
                    {
                        pontos += 5;
                        acertosTotais += 1;
                    }
                    if (bonus == true)
                    {
                        acertosClassicos += 1;
                        pontos = pontos * 2;
                    }
                }
                pontos_totais += pontos;
                //MessageBox.Show($"UPDATE participantes SET pontos = {pontos_totais}, acertosExatos = {acertosTotais}, acertosClassicos = {acertosClassicos}, precisaoAcertos = {(Nacertos * 100) / Npalpites} WHERE id = {id_participantes[i]}");

                comando = ($"UPDATE participantes SET pontos = {pontos_totais}, acertosExatos = {acertosTotais}, acertosClassicos = {acertosClassicos}, Num_palpites = {Npalpites}, Num_acertos = {Nacertos}, precisaoAcertos = {(Nacertos * 100) / Npalpites} WHERE id = {id_participantes[i]}");
                if (DataBase.Add_deletar_alterar(comando) == false)
                {
                    MessageBox.Show("Não foi possivel inserir os palpites");
                    break;
                }
            }
            comando = ($"UPDATE jogos SET status = false WHERE id = {id_jogo}");
            if (DataBase.Add_deletar_alterar(comando) == false)
            {
                MessageBox.Show("Não foi possivel inserir os palpites");
            }
            result = true;
            return result;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox2.Text = "";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBox1.Text = "";
        }

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox2.Text = "";
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox1.Text = "";
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox1.Text = "";
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox2.Text = "";
        }
    }
}
