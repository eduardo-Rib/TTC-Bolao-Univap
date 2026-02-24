using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolão_Univap
{
    public partial class adicionarRodadas : Form
    {
        private DateTime[] datas = new DateTime[100]; //armazena as datas das percelas
        private string[] time1 = new string[100]; //armazena os times 1 dos jogos
        private string[] time2 = new string[100]; //armazena os times 2 dos jogos
        private int cont = 0;


        public adicionarRodadas()
        {
            InitializeComponent();
        }

        private void adicionarRodadas_Load(object sender, EventArgs e) { MaximoMinimo(); }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Program.IntNumber(e); //Chama o método para permitir apenas que numeros inteiros sejam digitados
        }

        private void button1_Click_1(object sender, EventArgs e) // Botão que add o jogo
        {
            if ((textBox2.Text != "") && (textBox3.Text != "") && (dateTimePicker1.Value >= DateTime.Now))
            {
                if (textBox2.Text != textBox3.Text)
                {
                    this.time1[getCont()] = textBox2.Text; //guarda em "time1" o time 1
                    this.time2[getCont()] = textBox3.Text; //guarda em "time2" o time 2
                    this.datas[getCont()] = dateTimePicker1.Value.Date; //guarda em "datas" o dia do jogo
                    textBox1.Text += getCont() + 1 + " - " + time1[getCont()] + " X " + time2[getCont()] + Environment.NewLine;
                    setCont(1);
                    MaximoMinimo();

                    textBox2.Text = "";
                    textBox3.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Um time não pode jogar contra ele mesmo!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("" + getCont());
            if (getCont() > 0)
            {
                int c = int.Parse(numericUpDown1.Value.ToString());
                if (c == getCont())
                {
                    setCont(-1);
                }
                else
                {
                    for (int i = c-1; i < getCont() - 1; i++)
                    {
                        time1[i] = time1[i + 1];
                        time2[i] = time2[i + 1];
                        datas[i] = datas[i + 1];
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

        private void setCont(int valor)
        {
            this.cont = getCont() + valor;
        }

        private int getCont()
        {
            return this.cont;
        }

        private void MaximoMinimo()
        {
            numericUpDown1.Maximum = getCont();
            if (getCont() > 0)
            {
                if (getCont() != 1)
                {
                    numericUpDown1.Minimum = getCont()-(getCont()-1);
                }
                else
                {
                    numericUpDown1.Minimum = getCont();
                }
            }
        }

        private void printJogos()
        {
            textBox1.Text = "";
            for (int i = 0; i <= getCont()-1; i++)
            {
                textBox1.Text += i+1 + " - " + time1[i] + " X " + time2[i] + Environment.NewLine;
            }
        }
    }
}
