using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaoUnivap.Services
{
    internal class exportarExcel
    {

        //-----------------------------------------MODELO DE TABELA-----------------------------------------
        public class ExcelTable
        {
            public string SheetName;
            public List<string> Headers = new List<string>();
            public List<List<string>> Rows = new List<List<string>>();
        }



        //-----------------------------------------PREPARA CLASSIFICAÇÃO-----------------------------------------
        public static void classificacao(ListView listView)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar");
                return;
            }

            ExcelTable table = new ExcelTable();
            table.SheetName = "Classificação";


            //-------------------------Cabeçalho-------------------------

            foreach (ColumnHeader coluna in listView.Columns)
            {
                table.Headers.Add(coluna.Text);
            }


            //-------------------------LINHAS-------------------------

            foreach (ListViewItem item in listView.Items)
            {
                List<string> row = new List<string>();

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    row.Add(subItem.Text);
                }

                table.Rows.Add(row);
            }

            ExportarParaExcel(table);
        }



        //-----------------------------------------MÉTODO DE EXPORTAÇÃO-----------------------------------------
        public static void ExportarParaExcel(ExcelTable table)
        {

            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Excel |*.xlsx";

            if (salvar.ShowDialog() != DialogResult.OK)
                return;

            try
            {

                Excel.Application app = new Excel.Application();
                Excel.Workbook pasta = app.Workbooks.Add();
                Excel.Worksheet planilha = pasta.Worksheets.Add();

                planilha.Name = table.SheetName;

                int linha = 1;
                int coluna = 1;



                foreach (var header in table.Headers)
                {
                    planilha.Cells[linha, coluna] = header;
                    coluna++;
                }



                linha = 2;

                foreach (var row in table.Rows)
                {
                    coluna = 1;

                    foreach (var cell in row)
                    {
                        planilha.Cells[linha, coluna] = cell;
                        coluna++;
                    }

                    linha++;
                }



                pasta.SaveAs(salvar.FileName);
                pasta.Close();
                app.Quit();

                MessageBox.Show("Excel gerado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar Excel: " + ex.Message);
            }

        }

    }
}
