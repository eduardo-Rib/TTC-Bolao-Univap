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
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Google.Protobuf.WellKnownTypes;
using System.Data.Common;

namespace Bolão_Univap
{
    public partial class Administradores : Form
    {
        int adm;
        DataBase db = new DataBase();
        DataTable dt  = new DataTable();
        private int[] id = new int[100]; //armazena os emails
        private string[] email = new string[100]; //armazena os emails
        private int cont = 0;
        public Administradores(int adm)
        {
            InitializeComponent();
            this.adm = adm;
        }


        //---------------TODOS OS SET'S---------------
        private void setEmail(string valor, int indice)
        {
            this.email[indice] = valor;
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

        private string getEmail(int indice)
        {
            return this.email[indice];
        }

        private int getId(int indice)
        {
            return this.id[indice];
        }



        private void Administradores_Load(object sender, EventArgs e)
        {
            getEsteAdmonistrador();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = getEmail(comboBox1.SelectedIndex);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = default;
            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string senha = "";
                Random randNum = new Random();
                for (int i = 0; i < 8; i++)
                    senha += randNum.Next(0, 9);
                if (EnviarEmail(senha) == true)
                {
                    AdicionarAdministrador(textBox1.Text, senha);
                }
                else
                {
                    MessageBox.Show("não foi possivel encaminhar o email");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox3.Text != ""))
            {
                string email = textBox2.Text;
                string senha = textBox3.Text;
                if (senha.Length > 7)
                {
                    AtualizarAdministrador(email, senha);
                }
                else
                {
                    MessageBox.Show("A senha precisa ter pelo menos 8 digitos");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "") && (textBox5.Text != ""))
            {
                string comando = $"DELETE FROM administradores WHERE id = {getId(comboBox1.SelectedIndex)}";
                MessageBox.Show("" + getId(comboBox1.SelectedIndex));
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    //comando = ($"SELECT id, email FROM administradores WHERE id != {adm} ORDER BY id");
                    getAdministradores();
                    textBox5.Text = "";
                    comboBox1.Text = "";
                    MessageBox.Show("Administrador removido com sucesso");
                    
                }
                else
                {
                    MessageBox.Show("Não foi possivel remover o administrador");
                }
            }
        }


        public void getEsteAdmonistrador()
        {
            string comando = ($"SELECT email, senha FROM administradores WHERE id = {adm}");
            dt = DataBase.Consultas(comando);
            if (dt.Rows.Count > 0)
            {
                textBox2.Text = dt.Rows[0].Field<string>("email");
                textBox3.Text = dt.Rows[0].Field<string>("senha");
            }
            getAdministradores();
        }
        public void getAdministradores()
        {
            comboBox1.Items.Clear();
            string comando = ($"SELECT id, email FROM administradores WHERE id != {adm} ORDER BY id");
            dt = DataBase.Consultas(comando);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    AdicionarComboBoxAdministradores(i + 1);
                    setId(dt.Rows[i].Field<int>("id"), i);
                    setEmail(dt.Rows[i].Field<string>("email"), i);
                }
            }
        }


        public void AdicionarComboBoxAdministradores(int valor)
        {
            comboBox1.Items.Add(valor);
        }


        
        public void AtualizarAdministrador(string email, string senha)
        {
            string comando = $"UPDATE administradores SET email = '{email}', senha = '{senha}' WHERE id = {adm}";
            if (DataBase.Add_deletar_alterar(comando) == true)
            {
                MessageBox.Show("Alteração feita com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar a alteração");
            }
        }

        public void AdicionarAdministrador(string email, string senha)
        {
            string comando = $"INSERT INTO administradores (email, senha) VALUES('{email}', '{senha}')";
            if (DataBase.Add_deletar_alterar(comando) == true)
            {
                getAdministradores();
                MessageBox.Show("Administrador adicionado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possivel adicionar o administrador");
            }
        }

        public Boolean EnviarEmail(string senha)
        {
            Boolean result = false;
            //senha da conta: SistemaBolao2023
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        //Servidor SMTP
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("sistemabolaofutebol@gmail.com", "axrd sqld sths xjpt");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        //Email(message)
                        email.From = new MailAddress("sistemabolaofutebol@gmail.com");
                        email.To.Add(textBox1.Text);

                        email.Subject = "Senha de administrador do Bolão de Futebol";
                        email.IsBodyHtml = false;
                        email.Body = $"Ao realizar o login, utilizar a senha a seguir\n\nSenha: {senha}\n\nÉ possivel realizar a alteração da senha, após realizar o primeiro login.";

                        //Enviar email
                        smtp.Send(email);
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        
    }
}
