using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolão_Univap
{
    public partial class EditarRodadas : Form
    {

        DataTable dt = new DataTable();
        private DateTime[] datas = new DateTime[100]; //armazena as datas das percelas
        private string[] time1 = new string[100]; //armazena os times 1 dos jogos
        private string[] time2 = new string[100]; //armazena os times 2 dos jogos
        private int cont = 0;
        private int[] id = new int[100];

        public EditarRodadas()
        {
            InitializeComponent();
        }

        //-----------------------TODOS OS SET'S-----------------------
        private void setCont(int valor)
        {
            this.cont = getCont() + valor;
        }

        private void setId(int valor, int indice)
        {
            this.id[indice] = valor;
        }

        private void setDatas(DateTime valor, int indice)
        {
            this.datas[indice] = valor;
        }

        private void setTime1(string valor, int indice)
        {
            this.time1[indice] = valor;
        }

        private void setTime2(string valor, int indice)
        {
            this.time2[indice] = valor;
        }


        //-----------------------TODOS OS GET'S-----------------------
        private int getCont()
        {
            return this.cont;
        }

        private DateTime getDatas(int indice)
        {
            return this.datas[indice];
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




        private void EditarRodadas_Load(object sender, EventArgs e)
        {
            getRodadas();
        }



        public void AdicionarComboBoxRodadas(int id_rodada)
        {
            comboBox1.Items.Add(id_rodada);
        }

        public void AdicionarComboBoxJogos(int id_jogo)
        {
            comboBox2.Items.Add(id_jogo.ToString());
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string id_rodada = comboBox1.Text;
            comboBox2.Items.Clear();
            comboBox1.Text = "";
            getJogosDaRodada(id_rodada);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = getTime1(comboBox2.SelectedIndex);
            textBox2.Text = getTime2(comboBox2.SelectedIndex);
            dateTimePicker1.Value = getDatas(comboBox2.SelectedIndex);
            textBox4.Text = getDatas(comboBox2.SelectedIndex).ToString("HH");
            textBox5.Text = getDatas(comboBox2.SelectedIndex).ToString("mm");
        }



        //-------------------------Resgata as rodadas-------------------------
        public void getRodadas()
        {
            string comando = ($"SELECT id FROM rodadas WHERE status = true");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AdicionarComboBoxRodadas(dt.Rows[i].Field<int>("id"));
            }
        }


        //-------------------------Resgata os jogos da rodada selecionada-------------------------
        public void getJogosDaRodada(string id_rodada)
        {
            comboBox2.Items.Clear ();
            string comando = ($"SELECT id, time1, time2, horario FROM jogos WHERE id_Rodada = {id_rodada} AND status = true ORDER BY id");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AdicionarComboBoxJogos(i + 1);
                setId(dt.Rows[i].Field<int>("id"), i);
                setTime1(dt.Rows[i].Field<string>("time1"), i);
                setTime2(dt.Rows[i].Field<string>("time2"), i);
                setDatas(DateTime.Parse(dt.Rows[i].Field<string>("horario")), i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "" && comboBox2.SelectedIndex != -1)
            {
                DateTime dataJogo = dateTimePicker1.Value;
                DateTime dataHorarioJogo = new DateTime(dataJogo.Year, dataJogo.Month, dataJogo.Day, int.Parse(textBox4.Text), int.Parse(textBox5.Text), 00);
                if (dataHorarioJogo >= DateTime.Now)
                {
                    int id = getId(comboBox2.SelectedIndex);
                    string comando = ($"DELETE FROM jogos WHERE id = {id}");
                    if (DataBase.Add_deletar_alterar(comando) == true)
                    {
                        textBox2.Text = "";
                        textBox4.Text = "";
                        textBox1.Text = "";
                        textBox5.Text = "";
                        comboBox2.Text = "";

                        dateTimePicker1.Value = DateTime.Now;
                        MessageBox.Show("Jogo excluido");
                        getJogosDaRodada(comboBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel adicionar o participante");
                    }
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "" && comboBox2.SelectedIndex == -1)
            {
                DateTime dataJogo = dateTimePicker1.Value;
                DateTime dataHorarioJogo = new DateTime(dataJogo.Year, dataJogo.Month, dataJogo.Day, int.Parse(textBox4.Text), int.Parse(textBox5.Text), 00);
                if (dataHorarioJogo >= DateTime.Now)
                {
                    string comando_Jogos = $"INSERT INTO jogos (id_Rodada, time1, time2, bonus, horario, status) VALUES({comboBox1.Text}, '{textBox1.Text}', '{textBox2.Text}', {BonusAtivado(textBox1.Text, textBox2.Text)}, '{dataHorarioJogo.ToString()}', true)";
                    if (DataBase.Add_deletar_alterar(comando_Jogos) != true)
                    {
                        MessageBox.Show("Ocorreu um erro ao inserir os jogos");
                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox4.Text = "";
                        textBox1.Text = "";
                        textBox5.Text = "";
                        comboBox2.Text = "";


                        dateTimePicker1.Value = DateTime.Now;
                        MessageBox.Show("Jogo inserido");
                        getJogosDaRodada(comboBox1.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é possivel inserir um jogo com outro jogo já selecionado");
            }
        }

        public bool BonusAtivado(string time1, string time2)
        {
            Boolean result;
            Boolean result1 = false;
            Boolean result2 = false;


            string comando = ($"SELECT time FROM participantes");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (time1 == dt.Rows[i].Field<string>("time"))
                {
                    result1 = true;
                }

                if (time2 == dt.Rows[i].Field<string>("time"))
                {
                    result2 = true;
                }
            }

            if (result1 == true && result2 == true)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "" && comboBox2.SelectedIndex != -1)
            {
                DateTime dataJogo = dateTimePicker1.Value;
                DateTime dataHorarioJogo = new DateTime(dataJogo.Year, dataJogo.Month, dataJogo.Day, int.Parse(textBox4.Text), int.Parse(textBox5.Text), 00);
                if (dataHorarioJogo >= DateTime.Now)
                {
                    string comando = ($"UPDATE jogos SET time1 = '{textBox1.Text}', time2 = '{textBox2.Text}', bonus = {BonusAtivado(textBox1.Text, textBox2.Text)}, horario = '{dataHorarioJogo.ToString()}', status = true WHERE id = {getId(comboBox2.SelectedIndex)}");
                    if (DataBase.Add_deletar_alterar(comando) == true)
                    {
                        textBox2.Text = "";
                        textBox4.Text = "";
                        textBox1.Text = "";
                        textBox5.Text = "";
                        comboBox2.Text = "";

                        dateTimePicker1.Value = DateTime.Now;
                        MessageBox.Show(" Jogo atualizado");
                        getJogosDaRodada(comboBox1.Text);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel atualizar os dados do participante");
                    }
                }
                else
                {
                    MessageBox.Show("A data inserida tem que ser posterior a " + DateTime.Now.ToString());
                }

            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id_rodada = int.Parse(comboBox1.Text);
            
            if (comboBox1.Text != "")
            {
                string comando = ($"DELETE FROM rodadas WHERE id = {id_rodada}");
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    comando = ($"DELETE FROM jogos WHERE id_Rodada = {id_rodada}");
                    if (DataBase.Add_deletar_alterar(comando) == true)
                    {
                        comando = ($"DELETE FROM palpites WHERE id_Rodada = {id_rodada}");
                        if (DataBase.Add_deletar_alterar(comando) == true)
                        {
                            textBox2.Text = "";
                            textBox4.Text = "";
                            textBox1.Text = "";
                            textBox5.Text = "";
                            comboBox2.Text = "";
                            comboBox1.Text = "";


                            dateTimePicker1.Value = DateTime.Now;
                            MessageBox.Show("Rodada removida");

                            comboBox1.Items.Clear();
                            comboBox2.Items.Clear();
                            getRodadas();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox1.Text = "";
        }

        private void comboBox2_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox2.Text = "";
        }
    }
}
