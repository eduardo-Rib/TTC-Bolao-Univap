using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.PortableExecutable;


namespace Bolão_Univap
{
    public partial class Palpites : Form
    {

        DataTable dt = new DataTable();
        private string[] time1 = new string[100]; //armazena os times 1 dos jogos
        private string[] time2 = new string[100]; //armazena os times 2 dos jogos
        private int[] id = new int[100];
        private int[] id_participante = new int[100];
        private DateTime[] data = new DateTime[100];
        private int cont = 0;
        private Boolean InsertORUpdate = true;

        //---------------CONSTRUTOR---------------
        public Palpites()
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

        private void setId_participante(int valor, int indice)
        {
            this.id_participante[indice] = valor;
        }

        private void setHorarios(string valor, int indice)
        {
            this.data[indice] = DateTime.Parse(valor);
        }

        private void setInsertORUpdate(Boolean valor)
        {
            this.InsertORUpdate = valor;
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

        private int getId_participante(int indice)
        {
            return this.id_participante[indice];
        }

        private DateTime getData(int indice)
        {
            return this.data[indice];
        }

        private Boolean getInsertORUpdate()
        {
            return this.InsertORUpdate;
        }



        //---------------TODOS OS EVENTOS---------------
        private void Palipites_Load(object sender, EventArgs e)
        {
            getRodadas();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_rodada = comboBox1.Text;
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            getJogosDaRodada(id_rodada);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_jogo = getId(int.Parse(comboBox2.Text) - 1);
            textBox1.Text = getTime1(int.Parse(comboBox2.Text) - 1);
            textBox2.Text = getTime2(int.Parse(comboBox2.Text) - 1);
            if (comboBox3.SelectedIndex == -1)
            {
                comboBox3.Items.Clear ();
                getParticipantes(id_jogo);
            }
            else if (VerificarParticipante(getId(int.Parse(comboBox2.Text) - 1), getId_participante(comboBox3.SelectedIndex)) == false)
            {
                ResgatarResultados(getId(int.Parse(comboBox2.Text) - 1), getId_participante(comboBox3.SelectedIndex));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "" && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {
                if (getData(int.Parse(comboBox2.Text) - 1) > DateTime.Now)
                {
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
                    
                    AdicionarPalpite(comboBox1.Text, getId_participante(comboBox3.SelectedIndex), getId(int.Parse(comboBox2.Text) - 1), vencedor, gols_time1, gols_time2);
                 
                    
                }
                else
                {
                    MessageBox.Show("Não é possivel palpitar após o começo do jogo!");
                }
            }
            else
            {
                MessageBox.Show("Selecione e preencha corretamente os campos");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VerificarParticipante(getId(int.Parse(comboBox2.Text) - 1), getId_participante(comboBox3.SelectedIndex)) == false)
            {
                ResgatarResultados(getId(int.Parse(comboBox2.Text) - 1), getId_participante(comboBox3.SelectedIndex));
            }
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

        public void AdicionarComboBoxParticipantes(string nome)
        {
            comboBox3.Items.Add(nome);
            //MessageBox.Show("Nome = " + nome + "\nid é igual = " + id);
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

        public void getParticipantes(int id_jogo)
        {
            string comando = ($"SELECT id, nome FROM participantes ORDER BY id");
            dt = DataBase.Consultas(comando);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                setId_participante(dt.Rows[i].Field<int>("id"), i);
                AdicionarComboBoxParticipantes(dt.Rows[i].Field<string>("nome"));
            }
        }

        public void AdicionarPalpite(string id_rodada, int id_participante, int id_jogo, int vencedor, int gols_time1, int gols_time2)
        {
            if (VerificarParticipante(getId(int.Parse(comboBox2.Text) - 1), getId_participante(comboBox3.SelectedIndex)) == false)
            {
                string comando = ($"UPDATE palpites SET time_vencedor = {vencedor}, gols_time1 = {gols_time1}, gols_time2 = {gols_time2} WHERE id_participante = {id_participante} AND id_jogo = {id_jogo}");
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show(" Palpite atualizado");
                }
                else
                {
                    MessageBox.Show("Não foi possivel adicionar o palpite");
                }
            }
            else
            {
                string comando = ($"INSERT INTO palpites (id_participante, id_jogo, id_Rodada, time_vencedor, gols_time1, gols_time2) VALUES({id_participante}, {id_jogo}, {id_rodada}, {vencedor}, {gols_time1}, {gols_time2})");
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show(" Palpite adicionado");
                }
                else
                {
                    MessageBox.Show("Não foi possivel adicionar o palpite");
                }
            }

        }

        public Boolean VerificarParticipante(int jogo, int id)
        {
            Boolean result = false;
            textBox3.Text = "";
            textBox4.Text = "";
            string comando = ($"SELECT gols_time1, gols_time2 FROM palpites WHERE id_participante = {id} AND id_jogo = {jogo}");
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

        public void ResgatarResultados(int jogo, int id)
        {
            string comando = ($"SELECT gols_time1, gols_time2 FROM palpites WHERE id_participante = {id} AND id_jogo = {jogo}");
            dt = DataBase.Consultas(comando);

            if (dt.Rows.Count > 0)
            {
                textBox3.Text = dt.Rows[0].Field<int>("gols_time1").ToString();
                textBox4.Text = dt.Rows[0].Field<int>("gols_time2").ToString();
            }
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}