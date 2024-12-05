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

        public async Task AddProduct(Product product)
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
                        listView.Columns.Add("ID");
                        listView.Columns.Add("Nome");
                        listView.Columns.Add("Categoria");
                        listView.Columns.Add("Quantidade");
                        listView.Columns.Add("Preço");
                        listView.Columns.Add("Marca");
                        listView.Columns.Add("Fornecedor");
                        listView.Columns.Add("Código de Barras");

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
    }
}