using ManageProduct;
using Microsoft.Win32;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

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
                    var codBarras = selectedItem.SubItems[7].Text;
                    var descricao = selectedItem.SubItems[8].Text;
                    var custo = selectedItem.SubItems[9].Text;
                    var peso = selectedItem.SubItems[10].Text;
                    var volume = selectedItem.SubItems[11].Text;
                    var registro = selectedItem.SubItems[12].Text;
                    var validade = selectedItem.SubItems[13].Text;
                    var viewProd = new ViewProduct();
                    viewProd.SetAttributes(selectedItem.Text, nome, preco, qtd, marca, forne, categoria, codBarras, descricao, custo, peso, volume, registro, validade);
                    viewProd.hideEdit();
                    viewProd.ProductDeleted += async () => await LoadProductsAsync();
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
            var newProd = new CreateProd(listViewProducts);
            newProd.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterListView();
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

        }

        private async void btnFornecedor_Click(object sender, EventArgs e)
        {

        }

        private List<ListViewItem> originalItemList = new List<ListViewItem>(); //fiz um clone pra não afetar a lista original

        private void InitializeListView()
        {
            if (originalItemList.Count == 0)
            {
                foreach (ListViewItem item in listViewProducts.Items)
                {
                    originalItemList.Add((ListViewItem)item.Clone());
                }
            }
        }

        private void FilterListView()
        {
            InitializeListView();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listViewProducts.Items.Clear();
                foreach (var item in originalItemList)
                {
                    listViewProducts.Items.Add(item);
                }
            }
            else
            {
                List<ListViewItem> itemsToRemove = new List<ListViewItem>();

                foreach (ListViewItem item in listViewProducts.Items)
                {
                    if (!item.SubItems[1].Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        itemsToRemove.Add(item);
                    }
                }
                foreach (ListViewItem item in itemsToRemove)
                {
                    listViewProducts.Items.Remove(item);
                }
            }
        }

        private void btnDashboar_Click(object sender, EventArgs e)
        {

        }
    }
}
