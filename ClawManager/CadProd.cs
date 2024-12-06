using Stocku_.Db;
using Npgsql;

namespace ManageProduct
{
    public class CadProd
    {
        private readonly DbConnection C;

        public CadProd()
        {
            C = new();
        }

        public async Task AddProduct(Product product, ListView listView)
        {
            try
            {
                if (C.Connection.State != System.Data.ConnectionState.Open)
                {
                    await C.Connection.OpenAsync();
                }

                string query = "INSERT INTO \"Product\" (\"name\", \"description\", \"category\", \"supplierID\", \"qty\", \"brand\", \"costPrice\", \"sellPrice\", \"weight\", \"volume\", \"expirationDate\", \"registeredAt\", \"barCode\") VALUES (@name, @description, @category, @supplierID, @qty, @brand, @costPrice, @sellPrice, @weight, @volume, @expirationDate, @registeredAt, @barCode) RETURNING \"prodID\"";

                using (var cmd = new NpgsqlCommand(query, C.Connection))
                {
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@description", product.Description);
                    cmd.Parameters.AddWithValue("@category", product.Category);
                    cmd.Parameters.AddWithValue("@supplierID", product.SupplierID);
                    cmd.Parameters.AddWithValue("@qty", product.Qty);
                    cmd.Parameters.AddWithValue("@brand", product.Brand);
                    cmd.Parameters.AddWithValue("@costPrice", product.Cost);
                    cmd.Parameters.AddWithValue("@sellPrice", product.Price);
                    cmd.Parameters.AddWithValue("@weight", product.Weight);
                    cmd.Parameters.AddWithValue("@volume", product.Volume);
                    cmd.Parameters.AddWithValue("@registeredAt", product.RegisteredAt);
                    cmd.Parameters.AddWithValue("@expirationDate", product.ExpirationDate);
                    cmd.Parameters.AddWithValue("@barCode", product.BarCode);

                    var id = await cmd.ExecuteScalarAsync();
                    Console.WriteLine($"Product added with ID: {id}");


                    // Adiciona na lista 
                    var item = new ListViewItem(id.ToString());
                    item.SubItems.Add(product.Name);
                    item.SubItems.Add(product.Price.ToString("C"));
                    item.SubItems.Add(product.Qty.ToString());
                    item.SubItems.Add(product.Brand);
                    item.SubItems.Add(product.SupplierID.ToString());
                    item.SubItems.Add(product.Category);
                    item.SubItems.Add(product.BarCode);

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding product: {ex.Message}");
                throw;
            }
        }

        public async Task ListProducts(ListView listView)
        {
            try
            {
                if (C.Connection.State != System.Data.ConnectionState.Open)
                {
                    await C.Connection.OpenAsync();
                }

                string query = "SELECT \"prodID\", \"name\", \"description\", \"category\", \"supplierID\", \"qty\", \"brand\", \"costPrice\", \"sellPrice\", \"weight\", \"volume\", \"expirationDate\", \"registeredAt\", \"barCode\" FROM \"Product\"";

                using (var cmd = new NpgsqlCommand(query, C.Connection))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        listView.View = View.Details;
                        listView.Columns.Clear();
                        listView.Columns.Add("ID",73);
                        listView.Columns.Add("Nome",237);
                        listView.Columns.Add("Preço", 120);
                        listView.Columns.Add("Quantidade", 100);
                        listView.Columns.Add("Marca", 175);
                        listView.Columns.Add("Fornecedor", 175);
                        listView.Columns.Add("Categoria",180);
                        listView.Columns.Add("Código de Barras",0);
                        listView.TileSize = new Size(1, 50);

                        listView.Items.Clear();

                        while (await reader.ReadAsync())
                        {
                            var item = new ListViewItem(reader["prodID"].ToString());
                            item.SubItems.Add(reader["name"]?.ToString() ?? "");
                            item.SubItems.Add(reader["sellPrice"] != DBNull.Value
                                ? Convert.ToDecimal(reader["sellPrice"]).ToString("C") : "");
                            item.SubItems.Add(reader["qty"] != DBNull.Value
                                ? Convert.ToInt32(reader["qty"]).ToString() : "");
                            item.SubItems.Add(reader["brand"]?.ToString() ?? "");
                            item.SubItems.Add(reader["supplierID"]?.ToString() ?? "");
                            item.SubItems.Add(reader["category"]?.ToString() ?? "");

                            listView.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error listando produtos: {ex.Message}");
                throw;
            }
        }

        public async Task delProd(int prodID)
        {
            try
            {
                if (C.Connection.State != System.Data.ConnectionState.Open)
                {
                    await C.Connection.OpenAsync();
                }

                string query = "DELETE FROM \"Product\" WHERE \"prodID\" = @prodID";

                using (var cmd = new NpgsqlCommand(query, C.Connection))
                {
                    cmd.Parameters.AddWithValue("@prodID", prodID);

                    await cmd.ExecuteNonQueryAsync();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task<List<string[]>> genListProd()
        {
            try
            {
                if (C.Connection.State != System.Data.ConnectionState.Open)
                {
                    await C.Connection.OpenAsync();
                }

                // Cria uma lista para armazenar os dados dos produtos
                List<string[]> productList = new List<string[]>();

                string query = "SELECT \"prodID\", \"name\", \"description\", \"category\", \"supplierID\", \"qty\", \"brand\", \"costPrice\", \"sellPrice\", \"weight\", \"volume\", \"expirationDate\", \"registeredAt\", \"barCode\" FROM \"Product\"";

                using (var cmd = new NpgsqlCommand(query, C.Connection))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        // Itera sobre os resultados da consulta
                        while (await reader.ReadAsync())
                        {
                            // Adiciona os dados de cada produto na lista
                            string[] productData = new string[9]; // Array para armazenar os dados de um produto
                            productData[0] = reader["prodID"].ToString();
                            productData[1] = reader["name"]?.ToString() ?? "";
                            productData[2] = reader["description"]?.ToString() ?? "";
                            productData[3] = reader["category"]?.ToString() ?? "";
                            productData[4] = reader["supplierID"]?.ToString() ?? "";
                            productData[5] = reader["qty"] != DBNull.Value
                                ? Convert.ToInt32(reader["qty"]).ToString() : "";
                            productData[6] = reader["brand"]?.ToString() ?? "";
                            productData[7] = reader["sellPrice"] != DBNull.Value
                                ? Convert.ToDecimal(reader["sellPrice"]).ToString("C") : "";
                            productData[8] = reader["barCode"]?.ToString() ?? "";

                            productList.Add(productData);
                        }
                    }
                }

                // Retorna a lista de arrays de produtos
                return productList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar o array de produtos: {ex.Message}");
                throw;
            }
        }
    }
}