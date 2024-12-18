using Stocku_.Db;
using Npgsql;
using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using System.Text.RegularExpressions;
using System;
using System.Globalization;

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
                    item.SubItems.Add(product.Description);
                    item.SubItems.Add(product.Cost.ToString("C"));
                    item.SubItems.Add(product.Weight.ToString());
                    item.SubItems.Add(product.Volume.ToString());
                    item.SubItems.Add(product.RegisteredAt.ToString());
                    item.SubItems.Add(product.ExpirationDate.ToString());

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
                        listView.Columns.Add("ID", 73);
                        listView.Columns.Add("Nome", 237);
                        listView.Columns.Add("Pre�o", 120);
                        listView.Columns.Add("Quantidade", 100);
                        listView.Columns.Add("Marca", 175);
                        listView.Columns.Add("Fornecedor", 175);
                        listView.Columns.Add("Categoria", 180);
                        listView.Columns.Add("C�digo de Barras", 0);
                        listView.Columns.Add("Descri��o", 0);
                        listView.Columns.Add("Custo", 0);
                        listView.Columns.Add("Peso", 0);
                        listView.Columns.Add("Volume", 0);
                        listView.Columns.Add("Registro", 0);
                        listView.Columns.Add("Validade", 0);


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
                            item.SubItems.Add(reader["barCode"]?.ToString() ?? "");
                            item.SubItems.Add(reader["description"]?.ToString() ?? "");
                            item.SubItems.Add(reader["costPrice"] != DBNull.Value
                                 ? Convert.ToDecimal(reader["costPrice"]).ToString("C") : "");
                            item.SubItems.Add(reader["weight"] != DBNull.Value
                                 ? Convert.ToDecimal(reader["weight"]).ToString("") : "");
                            item.SubItems.Add(reader["volume"] != DBNull.Value
                                 ? Convert.ToDecimal(reader["volume"]).ToString("") : "");
                            string registeredAt = reader["registeredAt"] != DBNull.Value
                            ? DateOnly.FromDateTime((DateTime)reader["registeredAt"]).ToString("dd/MM/yyyy")
                            : "";
                            item.SubItems.Add(registeredAt);
                            string expirationDate = reader["expirationDate"] != DBNull.Value
                            ? DateOnly.FromDateTime((DateTime)reader["expirationDate"]).ToString("dd/MM/yyyy")
                            : "";
                            item.SubItems.Add(expirationDate);


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
        public async Task editProd(int prodID, string name, string price, string qty, string brand, string supplier,
        string category, string barCode, string description, string cost, string weight, string volume,
        string registeredAt, string expirationDate)
        {
            try
            {
                if (C.Connection.State != System.Data.ConnectionState.Open)
                {
                    await C.Connection.OpenAsync();
                }

                string query = @"
                UPDATE ""Product""
                SET ""name"" = @name,
                ""sellPrice"" = @price,
                ""qty"" = @qty,
                ""brand"" = @brand,
                ""supplierID"" = @supplier,
                ""category"" = @category,
                ""barCode"" = @barCode,
                ""description"" = @description,
                ""costPrice"" = @cost,
                ""weight"" = @weight,
                ""volume"" = @volume,
                ""registeredAt"" = @registeredAt,
                ""expirationDate"" = @expirationDate
                WHERE ""prodID"" = @prodID";

                using (var cmd = new NpgsqlCommand(query, C.Connection))
                {
                    cmd.Parameters.AddWithValue("@prodID", prodID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(price.Replace("$", "")));
                    cmd.Parameters.AddWithValue("@qty", int.Parse(qty));
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@supplier", int.Parse(supplier));
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@barCode", barCode);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@cost", decimal.Parse(cost.Replace("$", "")));
                    cmd.Parameters.AddWithValue("@weight", decimal.Parse(weight));
                    cmd.Parameters.AddWithValue("@volume", decimal.Parse(volume));
                    cmd.Parameters.AddWithValue("@registeredAt", DateTime.Now);
                    cmd.Parameters.AddWithValue("@expirationDate", DateOnly.ParseExact(expirationDate, "dd/MM/yyyy", CultureInfo.InvariantCulture));

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar o produto: {ex.Message}");
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