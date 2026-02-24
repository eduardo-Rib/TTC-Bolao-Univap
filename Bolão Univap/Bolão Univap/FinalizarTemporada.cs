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
    public partial class FinalizarTemporada : Form
    {

        DataTable dt = new DataTable(); 

        public FinalizarTemporada()
        {
            InitializeComponent();
        }

        private void FinalizarTemporada_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comando = "SELECT id FROM rodadas WHERE status = true";
            dt = DataBase.Consultas(comando);

            if (dt.Rows.Count == 0)
            {
                if (checkBox1.Checked)
                {
                    Form1 form1 = new Form1();
                    form1.ExportarParaExcel();
                }

                comando = ($"DELETE FROM rodadas");
                if (DataBase.Add_deletar_alterar(comando) == true)
                {
                    comando = ($"DELETE FROM jogos");
                    if (DataBase.Add_deletar_alterar(comando) == true)
                    {
                        comando = ($"DELETE FROM palpites");
                        if (DataBase.Add_deletar_alterar(comando) == true)
                        {
                            comando = ($"UPDATE participantes SET pontos = 0, acertosExatos = 0, acertosClassicos = 0, precisaoAcertos = 0, Num_palpites = 0, Num_acertos = 0");
                            if (DataBase.Add_deletar_alterar(comando) == true)
                            {
                                MessageBox.Show("Temporada encerrada com sucesso");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"Ainda há {dt.Rows.Count} rodadas para finalizar");
            }
        }
    }
}
