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

        public void SetAttributes(string id, string nome, string preco, string qtd, string marca, string forne, string categoria,
            string codBarras, string descricao, string custo, string peso, string volume, string registro, string validade)
        {
            ClearAttributes();
            lbID.Text = id;
            lbNome.Text = nome;
            lbPreco.Text = preco;
            lbEstoque.Text = qtd;
            lbMarca.Text = marca;
            lbProvedor.Text = forne;
            lbCategoria.Text = categoria;
            lbCodigoBarras.Text = codBarras;
            lbDescricao.Text = descricao;
            lbCusto.Text = custo;
            lbPeso.Text = peso;
            lbVolume.Text = volume;
            lbRegis.Text = registro;
            lbValidade.Text = validade;
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
            lbCodigoBarras.Text = null;
            lbDescricao.Text = null;
            lbCusto.Text = null;
            lbPeso.Text = null;
            lbVolume.Text = null;
            lbRegis.Text = null;
            lbValidade.Text = null;
        }


        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hideEdit();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(lbID.Text, out int prodID);
                string nome = tbNome.Text;
                string preco = tbPreco.Text;
                string estoque = tbEstoque.Text;
                string marca = tbMarca.Text;
                string provedor = tbProvedor.Text;
                string categoria = tbCategoria.Text;
                string codigoBarras = tbCodigoBarras.Text;
                string descricao = tbDescricao.Text;
                string custo = tbCusto.Text;
                string peso = tbPeso.Text;
                string volume = tbVolume.Text;
                string registro = tbRegis.Text;
                string validade = tbValidade.Text;

                CadProd cadProd = new CadProd();

                await cadProd.editProd(prodID, nome, preco, estoque, marca, provedor, categoria,
                    codigoBarras, descricao, custo, peso, volume, registro, validade);

                MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProdChanged?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            SetTextBoxVisibilityAndState(tbCodigoBarras, 100);
            tbCodigoBarras.Text = lbCodigoBarras.Text;
            SetTextBoxVisibilityAndState(tbDescricao, 100);
            tbDescricao.Text = lbDescricao.Text;
            SetTextBoxVisibilityAndState(tbCusto, 100);
            tbCusto.Text = lbCusto.Text;
            SetTextBoxVisibilityAndState(tbPeso, 100);
            tbPeso.Text = lbPeso.Text;
            SetTextBoxVisibilityAndState(tbVolume, 100);
            tbVolume.Text = lbVolume.Text;
            SetTextBoxVisibilityAndState(tbRegis, 100);
            tbRegis.Text = lbRegis.Text;
            SetTextBoxVisibilityAndState(tbValidade, 100);
            tbValidade.Text = lbValidade.Text;
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
            SetTextBoxVisibilityAndState(tbCodigoBarras, 0);
            SetTextBoxVisibilityAndState(tbDescricao, 0);
            SetTextBoxVisibilityAndState(tbCusto, 0);
            SetTextBoxVisibilityAndState(tbPeso, 0);
            SetTextBoxVisibilityAndState(tbVolume, 0);
            SetTextBoxVisibilityAndState(tbRegis, 0);
            SetTextBoxVisibilityAndState(tbValidade, 0);
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


        public event Action ProdChanged;
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
                    ProdChanged?.Invoke();
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

        private void tbPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRegis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
