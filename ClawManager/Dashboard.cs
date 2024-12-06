using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Stocku_.Db;
using ManageProduct;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClawManager
{
    public partial class Dashboard : Form
    {
        private readonly CadProd _cadProd;
        private readonly List<ListViewItem> _productItems;

        public Dashboard()
        {
            InitializeComponent();
            _cadProd = new CadProd();
            _productItems = new List<ListViewItem>();
        }

        private async void ExportToExcel()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                var productList = await _cadProd.genListProd();

                using (var package = new ExcelPackage())
                {
                    string sheetName = "Produtos_" + DateTime.Now.ToString("ddMMyyyy");

                    var worksheet = package.Workbook.Worksheets.Add(sheetName);

                    // Cabeçalho
                    worksheet.Cells[1, 1].Value = "ID";
                    worksheet.Cells[1, 2].Value = "Nome";
                    worksheet.Cells[1, 3].Value = "Preço";
                    worksheet.Cells[1, 4].Value = "Quantidade";
                    worksheet.Cells[1, 5].Value = "Marca";
                    worksheet.Cells[1, 6].Value = "Fornecedor";
                    worksheet.Cells[1, 7].Value = "Categoria";

                    int row = 2;
                    foreach (var product in productList)
                    {
                        worksheet.Cells[row, 1].Value = product[0];
                        worksheet.Cells[row, 2].Value = product[1];
                        worksheet.Cells[row, 3].Value = product[7];
                        worksheet.Cells[row, 4].Value = product[5];
                        worksheet.Cells[row, 5].Value = product[6];
                        worksheet.Cells[row, 6].Value = product[4];
                        worksheet.Cells[row, 7].Value = product[3];
                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    using (var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Arquivo Excel (.xlsx)|.xlsx",
                        Title = "Salvar Planilha",
                        FileName = sheetName + ".xlsx"  // Definindo o nome do arquivo automaticamente
                    })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var fileInfo = new System.IO.FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fileInfo);
                            MessageBox.Show("Planilha exportada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar para Excel: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genSheet_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir o Form1: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}