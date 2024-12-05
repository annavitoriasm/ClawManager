using ManageProduct;

namespace ClawManager
{
    public partial class Form1 : Form
    {
        private ListView listViewProducts;

        public Form1()
        {
            InitializeComponent();
            ConfigureForm();

            this.Load += async (sender, e) => await LoadProductsAsync();
        }

        private void ConfigureForm()
        {
            listViewProducts = new ListView
            {
                Dock = DockStyle.None,
                Width = 1080,
                Height = 530,
                FullRowSelect = true,
                GridLines = false,
                View = View.Details,
                BackColor = Color.FromArgb(62, 41, 71),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                HeaderStyle = ColumnHeaderStyle.None,
                BorderStyle = BorderStyle.None,
            };

            panel2.Controls.Add(listViewProducts);  // Adiciona o ListView ao painel2
            panel2.Controls.SetChildIndex(listViewProducts, 1);
            CenterListView();

            listViewProducts.Click += (sender, e) =>
            {
                if (listViewProducts.SelectedItems.Count > 0)
                {
                    var selectedItem = listViewProducts.SelectedItems[0]; //ID
                    var nome = selectedItem.SubItems[1].Text;
                    var preco = selectedItem.SubItems[2].Text;
                    var qtd = selectedItem.SubItems[3].Text;
                    var marca = selectedItem.SubItems[4].Text;
                    var forne = selectedItem.SubItems[5].Text;
                    var categoria = selectedItem.SubItems[6].Text;
                    var viewProd = new ViewProduct();
                    viewProd.SetAttributes(selectedItem.Text, nome, preco, qtd, marca, forne, categoria);
                    viewProd.ShowDialog();
                }
            };

        }

        private void CenterListView()
        {
            listViewProducts.Location = new Point(
            (panel2.Width - listViewProducts.Width) / 2,
            panel2.Height - listViewProducts.Height - 15);
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                var cadProd = new CadProd();
                await cadProd.ListProducts(listViewProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newProd = new CreateProd();
            newProd.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var viewProd = new ViewProduct();
            viewProd.ShowDialog();
        }
    }
}
