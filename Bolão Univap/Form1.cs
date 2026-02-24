using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bolão_Univap
{
    public partial class Form1 : Form
    {
        //-------------------------Construtor da classe form1-------------------------
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("POSIÇÃO", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("NOME", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("PONTOS", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Acertos Exatos", 110, HorizontalAlignment.Left);
            listView1.Columns.Add("Acertos Clássicos", 120, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase.ColetarParticipantes();
            PrintListView();
        }

        private void participantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Participantes participantes = new Participantes();
            participantes.ShowDialog();
        }



        //-------------------------Printa os participantes no ListView-------------------------
        public void PrintListView()
        {
            for (int i = 0; i < DataBase.Ap.getNum_Participantes(); i++)
            {
                string[] row =
                {
                    (i+1).ToString(),
                    DataBase.Ap.getParticipante(i).getNome(),
                    DataBase.Ap.getParticipante(i).getPontos().ToString(),
                    DataBase.Ap.getParticipante(i).getAcertosExatos().ToString(),
                    DataBase.Ap.getParticipante(i).getAcertosClassicos().ToString(),
                };
                var linha_TextView = new ListViewItem(row);
                listView1.Items.Add(linha_TextView);
            }
        }

        private void adicionarRodadasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adicionarRodadas adicionarRodadas = new adicionarRodadas();
            adicionarRodadas.ShowDialog();
        }
    }
}