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
    public partial class Participantes : Form
    {
        private DataBase db = new DataBase();
        public Participantes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                string nome = textBox1.Text;
                string time = textBox3.Text;
                if (db.AdicionarParticipante(nome, time) == true)
                {
                    textBox1.Text = "";
                    textBox3.Text = "";
                    label5.Text = "Adicionado";
                }
                else
                {
                    label5.Text = "Não foi possivel adicionar o participante";
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                /*string nome = textBox2.Text;
                DataBase.RemoverPcipante();
                textBox1.Text = "";
                textBox3.Text = "";
                label5.Text = "Adicionado";*/
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        private void Participantes_FormClosed(object sender, FormClosedEventArgs e) { }
        
    }
}
