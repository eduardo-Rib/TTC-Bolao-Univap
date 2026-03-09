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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void loading_Load(object sender, EventArgs e)
        {
            bool result = await Task.Run(() =>
                MigrationRunner.RunMigrations(UpdateProgress)
            );

            if (!result)
            {
                MessageBox.Show("Erro ao preparar o banco de dados.");
                Application.Exit();
                return;
            }

            this.Close();
        }   

        //-------------------------Atualiza a progress bar e label-------------------------
        private void UpdateProgress(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateProgress), value);
                return;
            }

            progressBar1.Value = value;
            label1.Text = "Carregando migrações... " + value + "%";
        }
    }
}
