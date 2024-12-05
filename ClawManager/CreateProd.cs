using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProduct;

namespace ClawManager
{
    public partial class CreateProd : Form
    {
        private readonly CadProd _addProduct;

        public CreateProd()
        {
            InitializeComponent();
            _addProduct = new CadProd();
        }

        private void CreateProd_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            tbNome.Clear();
            tbObservacoes.Clear();
            tbCategoria.Clear();
            tbProvedor.Clear();
            tbQtd.Clear();
            tbMarca.Clear();
            tbCusto.Clear();
            tbPreco.Clear();
            tbPeso.Clear();
            tbVolume.Clear();
            tbCodigoBarras.Clear();
            dtRegistro.Value = DateTime.Now;
            dtValidade.Value = DateTime.Now;
        }

        private async void btnCreateProd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var produto = new Product(
                    tbNome.Text,
                    tbObservacoes.Text,
                    tbCategoria.Text,
                    int.Parse(tbProvedor.Text),
                    int.Parse(tbQtd.Text),
                    tbMarca.Text,
                    decimal.Parse(tbCusto.Text),
                    decimal.Parse(tbPreco.Text),
                    decimal.Parse(tbPeso.Text),
                    decimal.Parse(tbVolume.Text),
                    DateOnly.FromDateTime(dtRegistro.Value),
                    DateOnly.FromDateTime(dtValidade.Value),
                    tbCodigoBarras.Text
                );

                await _addProduct.AddProduct(produto);

                MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao adicionar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
