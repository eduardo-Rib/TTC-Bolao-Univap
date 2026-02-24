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

namespace Bolão_Univap
{
    public partial class Participantes : Form
    {
        private string[] nome = new string[100]; 
        private string[] time = new string[100]; 
        private int[] id = new int[100];
        private int cont = 0;
        DataTable dt = new DataTable();

        public Participantes()
        {
            InitializeComponent();
        }


        //---------------TODOS OS SET'S---------------
        private void setNome(string valor, int indice)
        {
            this.nome[indice] = valor;
        }

        private void setTime(string valor, int indice)
        {
            this.time[indice] = valor;
        }

        private void setCont(int valor)
        {
            this.cont = getCont() + valor;
        }

        private void setId(int valor, int indice)
        {
            this.id[indice] = valor;
        }

        //---------------TODOS OS GET'S---------------
        private int getCont()
        {
            return this.cont;
        }

        private string getNome(int indice)
        {
            return this.nome[indice];
        }

        private string getTime(int indice)
        {
            return this.time[indice];
        }

        private int getId(int indice)
        {
            return this.id[indice];
        }


        //----------------Adicionar no ComboBox-----------------

        public void AdicionarComboBoxParticipantes(int nome)
        {
            comboBox1.Items.Add(nome);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = getNome(comboBox1.SelectedIndex);
            textBox4.Text = getTime(comboBox1.SelectedIndex);
        }
        private void Participantes_Load(object sender, EventArgs e)
        {
            ResgatarParticipantes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //------------------Adiciona os Participantess------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                string nome = textBox1.Text;
                string time = textBox3.Text;
                string comando = ($"INSERT INTO participantes (nome, time, pontos, acertosExatos, acertosClassicos, precisaoAcertos, Num_palpites, Num_acertos) VALUES('{nome}', '{time}', 0, 0, 0, 0, 0, 0)");
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    textBox1.Text = "";
                    textBox3.Text = "";
                    MessageBox.Show("Participante adicionado");
                    ResgatarParticipantes();
                }
                else
                {
                    MessageBox.Show("Não foi possivel adicionar o participante");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        //------------------Remove os Participantess------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox4.Text != "" && comboBox1.SelectedIndex != -1)
            {
                int id = getId(comboBox1.SelectedIndex);
                string comando = ($"DELETE FROM participantes WHERE id = {id}");
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    textBox2.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    ResgatarParticipantes();
                    MessageBox.Show(" Participante removido");
                }
                else
                {
                    MessageBox.Show("Não foi possivel remover o participante");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        //------------------Edita os Participantess------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox4.Text != "" && comboBox1.SelectedIndex != -1)
            {
                int id = getId(comboBox1.SelectedIndex);
                string nome = textBox2.Text;
                string time = textBox4.Text;
                string comando = ($"UPDATE participantes SET nome = '{nome}', time = '{time}' WHERE id = {id}");
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    textBox2.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    ResgatarParticipantes();
                    MessageBox.Show(" Participante atualizado");
                }
                else
                {
                    MessageBox.Show("Não foi possivel atualizar os dados do participante");
                }
            }
            else
            {
                MessageBox.Show("É necessário preencher os campos corretamente!");
            }
        }

        private void Participantes_FormClosed(object sender, FormClosedEventArgs e) { }

        public void ResgatarParticipantes()
        {
            comboBox1.Items.Clear();    
            string comando = ($"SELECT id, nome, time FROM participantes ORDER BY id");
            dt = DataBase.Consultas(comando);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    AdicionarComboBoxParticipantes(i + 1);
                    setId(dt.Rows[i].Field<int>("id"), i);
                    setNome(dt.Rows[i].Field<string>("nome"), i);
                    setTime(dt.Rows[i].Field<string>("time"), i);
                }
            }
        }
    }
}
