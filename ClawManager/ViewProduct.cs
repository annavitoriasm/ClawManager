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

    }
}
