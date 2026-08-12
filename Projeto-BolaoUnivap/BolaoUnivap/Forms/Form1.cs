using BolaoUnivap.Database;
using BolaoUnivap.Services;
using System.Data;

namespace BolaoUnivap
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        bool LOGIN = false;
        int Adm = 0;

        enum funcao
        {
            Participantes,
            Rodadas,
            Palpites,
            LogOut,
            Resultados,
            Administradores
        }

        private funcao Menu;

        //-------------------------CONSTRUTOR-------------------------
        public Form1()
        {
            InitializeComponent();

            loading loading = new loading();
            loading.ShowDialog();

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
                Menu = funcao.Participantes;
                ColetarParticipantes();
            }
        }



        //----------------------------CHAMA O BANCO PARA RESGATAR OS PARTICIPANTES-----------------------------------
        public void ColetarParticipantes()
        {
            string comando = @"
                SELECT 
                    p.nome,
                    COALESCE(SUM(
                        CASE
                            WHEN pal.gols_time1 = j.gols_time1
                             AND pal.gols_time2 = j.gols_time2
                            THEN 3 * j.bonus

                            WHEN SIGN(pal.gols_time1 - pal.gols_time2) =
                                 SIGN(j.gols_time1 - j.gols_time2)
                            THEN 1 * j.bonus

                            ELSE 0
                        END
                    ), 0) AS pontos

                FROM participantes p

                LEFT JOIN palpites pal 
                    ON pal.id_participante = p.id_participante

                LEFT JOIN jogos j 
                    ON j.id_jogo = pal.id_jogo
                    AND j.gols_time1 IS NOT NULL
                    AND j.gols_time2 IS NOT NULL

                GROUP BY p.id_participante, p.nome

                ORDER BY pontos DESC;
            ";
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

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] row =
                {
                    (i+1).ToString(),
                    dt.Rows[i].Field<string>("nome"),
                    dt.Rows[i].Field<decimal>("pontos").ToString(),
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
                ColetarParticipantes();
                Menu = funcao.Participantes;
            }
            else
            {
                Login login = new Login(this);
                login.ShowDialog();
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
                Login login = new Login(this);
                login.ShowDialog();
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
                Login login = new Login(this);
                login.ShowDialog();
            }
        }



        //----------------------------BOTÃO DE INCLUIR NOVO CADASTRO-----------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                switch (Menu)
                {
                    case funcao.Participantes:
                        Participantes participantes = new Participantes();
                        participantes.ShowDialog();
                        break;
                }
            }
            else
            {
                Login login = new Login(this);
                login.ShowDialog();
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
                Login login = new Login(this);
                login.ShowDialog();
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
                Login login = new Login(this);
                login.ShowDialog();
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
                Login login = new Login(this);
                login.ShowDialog();
            }
        }

        private void rodadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                ColetarParticipantes();
                Menu = funcao.Participantes;
            }
            else
            {
                Login login = new Login(this);
                login.ShowDialog();
            }
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
                Login login = new Login(this);
                login.ShowDialog();
            }
        }



        //----------------------------BOTÃO PARA EXPORTAR PARA EXCEL-----------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            if (getLOGIN())
            {
                if (listView1.Items.Count > 0)
                {
                    exportarExcel.classificacao(listView1);
                }
                else
                {
                    MessageBox.Show("Não há dados para exportar");
                }
            }
            else
            {
                Login login = new Login(this);
                login.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}