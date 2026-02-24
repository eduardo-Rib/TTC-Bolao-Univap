using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bolão_Univap
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        bool LOGIN = false;
        int Adm = 0;

        //-------------------------CONSTRUTOR-------------------------
        public Form1()
        {
            InitializeComponent();

            Login login = new Login(this);
            login.ShowDialog();

            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = false;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("POSIÇÃO", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("NOME", 140, HorizontalAlignment.Left);
            listView1.Columns.Add("PONTOS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ACERTOS EXATOS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ACERTOS CLÁSSICOS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("PRECISÃO ACERTOS", 100, HorizontalAlignment.Left);
            listView1.Columns.Clear();
        }



        //----------------------------SET'S-----------------------------------
        public void setLOGIN(bool valor)
        {
            this.LOGIN = valor;
        }

        public void setADM(int valor)
        {
            this.Adm = valor;
            label1.Text = getADM().ToString();
        }



        //----------------------------GET'S-----------------------------------
        public bool getLOGIN()
        {
            return LOGIN;
        }

        public int getADM()
        {
            return Adm;
        }



        //----------------------------INICIA A CLASSIFICAÇÃO-----------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                ColetarParticipantes();
            }
        }



        //----------------------------CHAMA O BANCO PARA RESGATAR OS PARTICIPANTES-----------------------------------
        public void ColetarParticipantes()
        {
            string comando = ($"SELECT nome, pontos, acertosExatos, acertosClassicos, precisaoAcertos FROM participantes ORDER BY pontos DESC, acertosExatos DESC, acertosClassicos DESC, precisaoAcertos DESC");
            dt = DataBase.Consultas(comando);
            PrintListView(dt);
        }
        //-------------------------Printa os participantes no ListView-------------------------
        public void PrintListView(DataTable dt)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("POSIÇÃO", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("NOME", 140, HorizontalAlignment.Left);
            listView1.Columns.Add("PONTOS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ACERTOS EXATOS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("ACERTOS CLÁSSICOS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("PRECISÃO ACERTOS", 100, HorizontalAlignment.Left);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] row =
                {
                    (i+1).ToString(),
                    dt.Rows[i].Field<string>("nome"),
                    dt.Rows[i].Field<int>("pontos").ToString(),
                    dt.Rows[i].Field<int>("acertosExatos").ToString(),
                    dt.Rows[i].Field<int>("acertosClassicos").ToString(),
                    dt.Rows[i].Field<float>("precisaoAcertos").ToString(),
                };
                var linha_TextView = new ListViewItem(row);
                listView1.Items.Add(linha_TextView);
            }
        }



        //----------------------------TELA DE MANIPULAÇÃO DE PARTICIPANTES-----------------------------------
        private void participantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                Participantes participantes = new Participantes();
                participantes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }

        }



        //----------------------------TELA PARA ADICIONAR RODADAS-----------------------------------
        private void adicionarRodadasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                adicionarRodadas adicionarRodadas = new adicionarRodadas();
                adicionarRodadas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }



        //----------------------------TELA DE INSERÇÃO DE PALPITES-----------------------------------
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                Palpites palpites = new Palpites();
                palpites.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }



        //----------------------------BOTÃO DE ATUALIZAR CLASSIFICAÇÃO-----------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                ColetarParticipantes();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }



        //----------------------------TELA DE ADMINISTRADORES-----------------------------------
        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                Administradores administradores = new Administradores(getADM());
                administradores.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }



        //----------------------------TELA PARA INSERIR RESULTADOS-----------------------------------
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                Resultados resultados = new Resultados();
                resultados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }



        //----------------------------TELA DE CUSTOMIZAR RODADAS-----------------------------------
        private void customizarRodadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                EditarRodadas editarRodadas = new EditarRodadas();
                editarRodadas.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }

        private void rodadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



        //----------------------------LOG-OUT OR LOGIN-----------------------------------
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                setLOGIN(false);
                MessageBox.Show("Sessão encerrada");
            }
            Login login = new Login(this);
            login.ShowDialog();
        }



        //----------------------------TELA DE FINALIZAR TEMPORADA-----------------------------------
        private void finalizarTemporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                FinalizarTemporada finalizarTemporada = new FinalizarTemporada();
                finalizarTemporada.ShowDialog();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }



        //----------------------------BOTÃO PARA EXPORTAR PARA EXCEL-----------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                ExportarParaExcel();
            }
            else
            {
                MessageBox.Show("Faça login para ter acesso a essa funcionalidade!");
            }
        }


        //----------------------------METÓDO QUE CRIA O ARQUIVO EXCEL-----------------------------------
        public void ExportarParaExcel()
        {
            if (listView1.Items.Count > 0)
            {
                SaveFileDialog Local = new SaveFileDialog();
                Local.Filter = "Excel |*.xlsx";
                Local.ShowDialog();

                try
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook pasta = app.Workbooks.Add();
                    Microsoft.Office.Interop.Excel.Worksheet planilha;
                    planilha = pasta.Worksheets.Add();
                    planilha.Name = "Classificação";

                    int linha = 2, coluna = 1;

                    planilha.Cells[1, 1] = listView1.Columns[0].Text;
                    planilha.Cells[1, 2] = listView1.Columns[1].Text;
                    planilha.Cells[1, 3] = listView1.Columns[2].Text;
                    planilha.Cells[1, 4] = listView1.Columns[3].Text;
                    planilha.Cells[1, 5] = listView1.Columns[4].Text;
                    planilha.Cells[1, 6] = listView1.Columns[5].Text;

                    foreach (ListViewItem lvItem in listView1.Items)
                    {
                        coluna = 1;
                        foreach (ListViewItem.ListViewSubItem lvSubItem in lvItem.SubItems)
                        {
                            planilha.Cells[linha, coluna] = lvSubItem.Text;
                            coluna++;
                        }
                        linha++;
                    }

                
                    pasta.SaveAs(Local.FileName);
                    pasta.Close();
                    app.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Excel gerado no diretório selecionado");
            }
            else
            {
                MessageBox.Show("Não há dados para exportar");
            }
        }  
    }
}