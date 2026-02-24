using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Utilities;
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
    public partial class adicionarRodadas : Form
    {

        private DateTime[] datas = new DateTime[100]; //armazena as datas das percelas
        private string[] time1 = new string[100]; //armazena os times 1 dos jogos
        private string[] time2 = new string[100]; //armazena os times 2 dos jogos
        DataTable dt = new DataTable();
        private int cont = 0;

        //-----------------------CONSTRUTOR-----------------------
        public adicionarRodadas()
        {
            InitializeComponent();
        }

        //-----------------------TODOS OS SET'S-----------------------
        private void setCont(int valor)
        {
            this.cont = getCont() + valor;
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

        private void adicionarRodadas_Load(object sender, EventArgs e)
        {
            MaximoMinimo();
        }

        //-----------------------Botão que add o jogo-----------------------
        private void button1_Click_1(object sender, EventArgs e)
        {
            //(dateTimePicker1.Value >= DateTime.Now)
            if ((textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != ""))
            {
                if (int.Parse(textBox4.Text) < 24 || int.Parse(textBox5.Text) < 60)
                {
                    DateTime dataJogo = dateTimePicker1.Value;
                    DateTime dataHorarioJogo = new DateTime(dataJogo.Year, dataJogo.Month, dataJogo.Day, int.Parse(textBox4.Text), int.Parse(textBox5.Text), 00);
                    if (dataHorarioJogo > DateTime.Now)
                    {
                        if (textBox2.Text != textBox3.Text)
                        {
                            setTime1(textBox2.Text, getCont()); //guarda em "time1" o time 1
                            setTime2(textBox3.Text, getCont()); //guarda em "time2" o time 2
                            setDatas(dataHorarioJogo, getCont()); //guarda em "datas" o dia do jogo
                            setCont(1);
                            MaximoMinimo();

                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            dateTimePicker1.Value = DateTime.Now;
                            printJogos();
                        }
                        else
                        {
                            MessageBox.Show("Um time não pode jogar contra ele mesmo!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A data inserida tem que ser posterior a " + DateTime.Now.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("O horário inserido é invalido");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente");
            }
        }

        //-----------------------Botão que remove o jogo-----------------------
        private void button3_Click(object sender, EventArgs e)
        {
            if (getCont() > 0)
            {
                int c = int.Parse(numericUpDown1.Value.ToString());
                if (c == getCont())
                {
                    setCont(-1);
                }
                else
                {
                    for (int i = c - 1; i < getCont() - 1; i++)
                    {
                        setTime1(getTime1(i + 1), i);
                        setTime2(getTime2(i + 1), i);
                        setDatas(getDatas(i + 1), i);
                    }
                    setCont(-1);
                }
                printJogos();
                MaximoMinimo();
            }
            else
            {
                MessageBox.Show("jogo inválido!");
            }
        }

        //-----------------------Botão que cria a rodada-----------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string comando_rodada = $"INSERT INTO rodadas (status) VALUES(true)";
                if (DataBase.Add_deletar_alterar(comando_rodada) == true)
                {
                    string comando = ($"SELECT id FROM rodadas ORDER BY id DESC");
                    dt = DataBase.Consultas(comando);
                    int id_rodada = dt.Rows[0].Field<int>("id");

                    for (int i = 0; i < getCont(); i++)
                    {
                        string comando_Jogos = $"INSERT INTO jogos (id_Rodada, time1, time2, bonus, horario, status) VALUES({id_rodada}, '{getTime1(i)}', '{getTime2(i)}', {BonusAtivado(getTime1(i), getTime2(i))}, '{getDatas(i).ToString()}', true)";
                        if (DataBase.Add_deletar_alterar(comando_Jogos) != true)
                        {
                            MessageBox.Show("Ocorreu um erro ao inserir os jogos");
                            break;
                        }
                    }
                    textBox1.Text = "";
                    setCont(-getCont());
                    MaximoMinimo();
                    MessageBox.Show("Rodada adicionada");
                }
                else
                {
                    MessageBox.Show("Não foi possivel adicionar a rodada");
                }
            }
            else
            {
                MessageBox.Show("É necessário inserir jogos na rodada");
            }
        }



        //-----------------------Determina o Minimo e o Maximo do numericUpDown-----------------------
        private void MaximoMinimo()
        {
            numericUpDown1.Maximum = getCont(); 
            if (getCont() > 0)
            {
                if (getCont() != 1)
                {
                    numericUpDown1.Minimum = getCont() - (getCont() - 1);
                }
                else
                {
                    numericUpDown1.Minimum = getCont();
                }
            }
        }

        //-----------------------Printa os jogos na tela-----------------------
        private void printJogos()
        {
            textBox1.Text = "";
            for (int i = 0; i <= getCont() - 1; i++)
            {
                textBox1.Text += i + 1 + " - " + time1[i] + " X " + time2[i] + Environment.NewLine;
            }
        }



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //-------------------------Verifica se o jogo é um classico ou nao-------------------------
        public bool BonusAtivado(string time1, string time2)
        {
            Boolean result;
            Boolean result1 = false;
            Boolean result2 = false;


            string comando = ($"SELECT time FROM participantes");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++) // Palmeiras BoccaJuniors
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}
