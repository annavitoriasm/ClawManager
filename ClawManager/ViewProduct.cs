using ManageProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClawManager
{
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void lbCodigoBarras_Click(object sender, EventArgs e)
        {

        }

        private void lbCusto_Click(object sender, EventArgs e)
        {

        }

        private void lbPeso_Click(object sender, EventArgs e)
        {

        }

        private void lbVolume_Click(object sender, EventArgs e)
        {

        }

        private void lbEstoque_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbRegistro_Click(object sender, EventArgs e)
        {

        }

        private void lbPreco_Click(object sender, EventArgs e)
        {

        }

        private void lbMarca_Click(object sender, EventArgs e)
        {

        }

        private void lbProvedor_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseView_Click(object sender, EventArgs e)
        {
            ClearAttributes();
            this.Close();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lbID_Click(object sender, EventArgs e)
        {
        }

        public void SetAttributes(string id, string nome, string preco, string qtd,
            string marca, string forne, string categoria)
        {
            ClearAttributes();
            lbID.Text = id;
            lbNome.Text = nome;
            lbPreco.Text = preco;
            lbEstoque.Text = qtd;
            lbMarca.Text = marca;
            lbProvedor.Text = forne;
            lbCategoria.Text = categoria;

        }

        public void ClearAttributes()
        {
            lbID.Text = null;
            lbNome.Text = null;
            lbPreco.Text = null;
            lbEstoque.Text = null;
            lbMarca.Text = null;
            lbProvedor.Text = null;
            lbCategoria.Text = null;

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hideEdit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void showEdit()
        {
            SetButtonOpacity(btnCancel, 100);
            SetButtonOpacity(btnConfirm, 100);
            SetButtonOpacity(btnHoverEditar, 100);
            btnCancel.ForeColor = Color.White;
            btnCancel.BackColor = Color.Transparent;
            SetTextBoxVisibilityAndState(tbNome, 100);
            tbNome.Text = lbNome.Text;
            SetTextBoxVisibilityAndState(tbPreco, 100);
            tbPreco.Text = lbPreco.Text;
            SetTextBoxVisibilityAndState(tbEstoque, 100);
            tbEstoque.Text = lbEstoque.Text;
            SetTextBoxVisibilityAndState(tbMarca, 100);
            tbMarca.Text = lbMarca.Text;
            SetTextBoxVisibilityAndState(tbProvedor, 100);
            tbProvedor.Text = lbProvedor.Text;
            SetTextBoxVisibilityAndState(tbCategoria, 100);
            tbCategoria.Text = lbCategoria.Text;
        }

        public void hideEdit()
        {
            SetButtonOpacity(btnCancel, 0);
            SetButtonOpacity(btnConfirm, 0);
            SetButtonOpacity(btnHoverEditar, 0);
            SetTextBoxVisibilityAndState(tbNome, 0);
            SetTextBoxVisibilityAndState(tbPreco, 0);
            SetTextBoxVisibilityAndState(tbEstoque, 0);
            SetTextBoxVisibilityAndState(tbMarca, 0);
            SetTextBoxVisibilityAndState(tbProvedor, 0);
            SetTextBoxVisibilityAndState(tbCategoria, 0);
        }

        public void SetButtonOpacity(Button button, int opacity)
        {
            int alpha = (int)(opacity * 2.55);

            if (opacity == 0)
            {
                button.Enabled = false;
                button.Visible = false;
            }
            else
            {
                button.Enabled = true;
                button.Visible = true;
            }
        }

        public void SetTextBoxVisibilityAndState(TextBox textBox, int opacity)
        {
            int alpha = (int)(opacity * 2.55);

            if (opacity == 0)
            {
                textBox.Enabled = false;
                textBox.Visible = false;
            }
            else
            {
                textBox.Enabled = true;
                textBox.Visible = true;
            }
        }


        private async void btnEditar_Click(object sender, EventArgs e)
        {
            int.TryParse(lbID.Text, out int prodID);

            var confirmResult = MessageBox.Show(
                "Tem certeza de que deseja excluir este produto?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                CadProd cadProd = new CadProd();

                try
                {
                    await cadProd.delProd(prodID);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            showEdit();
        }
    }
}
