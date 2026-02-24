using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public Login(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string senha = textBox2.Text;

            if (email != "" && senha != "")
            {
                string comando = $"SELECT id FROM administradores WHERE email = '{email}' AND senha = '{senha}'";
                dt = DataBase.Consultas(comando);
                if (dt.Rows.Count == 1)
                {
                    int id = dt.Rows[0].Field<int>("id");
                    form1.setADM(id);
                    form1.setLOGIN(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email e/ou senha invalido(os)");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Text = "testes@gmail.com";
            textBox2.Text = "72625348";
        }
    }
}
