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
                Width = 1000,
                Height = 530,
                FullRowSelect = true,
                GridLines = true,
                View = View.Details
            };

            this.Controls.Add(listViewProducts);
            this.Controls.SetChildIndex(listViewProducts, 1);
            this.BackColor = Color.FromArgb(62, 41, 71);
            listViewProducts.Location = new Point(205, 141);
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
