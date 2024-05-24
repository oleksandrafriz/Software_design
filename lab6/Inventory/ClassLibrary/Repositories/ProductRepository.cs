using System;
using System.Collections.Generic;
using ClassLibrary.Helpers;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySqlDbHelper _dbHelper;

        public ProductRepository(string connectionString)
        {
            _dbHelper = new MySqlDbHelper(connectionString);
        }

        public void AddProduct(Product product)
        {
            const string query = "INSERT INTO tovars (tov_name, quantity, price, id_postach) VALUES (@tov_name, @quantity, @price, @id_postach)";
            ExecuteNonQuery(query, cmd =>
            {
                AddProductParameters(cmd, product);
            });
            ExecuteNonQuery(query, cmd => SetProductParameters(cmd, product));
        }

        public void UpdateProduct(Product product)
        {
            const string query = "UPDATE tovars SET tov_name = @tov_name, quantity = @quantity, price = @price, id_postach = @id_postach WHERE id_tovar = @id_tovar";
            ExecuteNonQuery(query, cmd =>
            {
                AddProductParameters(cmd, product);
                cmd.Parameters.AddWithValue("@id_tovar", product.Id);
            });
            ExecuteNonQuery(query, cmd => SetProductParameters(cmd, product, true));
        }

        public void DeleteProduct(int productId)
        {
            const string query = "DELETE FROM tovars WHERE id_tovar = @id_tovar";
            _dbHelper.ExecuteNonQuery(query, cmd => cmd.Parameters.AddWithValue("@id_tovar", productId));
        }

        public List<Product> GetAllProducts()
        {
            const string query = @"
                    SELECT t.id_tovar, t.tov_name, t.quantity, t.price, p.name_postach
                    FROM tovars t
                    JOIN postachalnik p ON t.id_postach = p.id_postach";
            return _dbHelper.ExecuteReader(query, reader => MapReaderToProduct(reader));
        }

        public Product GetProductById(int productId)
        {
            const string query = @"
            SELECT t.id_tovar, t.tov_name, t.quantity, t.price, p.name_postach
            FROM tovars t
            JOIN postachalnik p ON t.id_postach = p.id_postach
            WHERE t.id_tovar = @id_tovar";
            return _dbHelper.ExecuteReaderSingle(query, cmd => cmd.Parameters.AddWithValue("@id_tovar", productId), reader => MapReaderToProduct(reader));
        }

        public List<Product> SearchProductsByName(string name)
        {
            const string query = @"
            SELECT t.id_tovar, t.tov_name, t.quantity, t.price, p.name_postach
            FROM tovars t
            JOIN postachalnik p ON t.id_postach = p.id_postach
            WHERE t.tov_name LIKE @name";
            return _dbHelper.ExecuteReader(query, cmd => cmd.Parameters.AddWithValue("@name", "%" + name + "%"), reader => MapReaderToProduct(reader));
        }

        private void ExecuteNonQuery(string query, Action<MySqlCommand> parameterize)
        {
            _dbHelper.ExecuteNonQuery(query, parameterize);
        }

        private void SetProductParameters(MySqlCommand cmd, Product product, bool includeId = false)
        {
            cmd.Parameters.AddWithValue("@tov_name", product.Name);
            cmd.Parameters.AddWithValue("@quantity", product.Quantity);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@id_postach", product.Postachalnik);

            if (includeId)
            {
                cmd.Parameters.AddWithValue("@id_tovar", product.Id);
            }
        }

        private Product MapReaderToProduct(MySqlDataReader reader)
        {
            return new Product
            {
                Id = Convert.ToInt32(reader["id_tovar"]),
                Name = reader["tov_name"].ToString(),
                Quantity = Convert.ToInt32(reader["quantity"]),
                Price = Convert.ToDecimal(reader["price"]),
                Postachalnik = reader["name_postach"].ToString()
            });
        }

        public Product GetProductById(int productId)
        {
            const string query = "SELECT * FROM tovars WHERE id_tovar = @id_tovar";
            return ExecuteReaderSingle(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@id_tovar", productId);
            }, reader => new Product
            {
                Id = Convert.ToInt32(reader["id_tovar"]),
                Name = reader["tov_name"].ToString(),
                Quantity = Convert.ToInt32(reader["quantity"]),
                Price = Convert.ToDecimal(reader["price"]),
                Postachalnik = reader["id_postach"].ToString()
            });
        }

        public List<Product> SearchProductsByName(string name)
        {
            const string query = "SELECT * FROM tovars WHERE tov_name LIKE @name";
            return ExecuteReader(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@name", "%" + name + "%");
            }, reader => new Product
            {
                Id = Convert.ToInt32(reader["id_tovar"]),
                Name = reader["tov_name"].ToString(),
                Quantity = Convert.ToInt32(reader["quantity"]),
                Price = Convert.ToDecimal(reader["price"])
            });
        }

        private void ExecuteNonQuery(string query, Action<MySqlCommand> parameterize)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    parameterize(cmd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private List<Product> ExecuteReader(string query, Func<MySqlDataReader, Product> readRow)
        {
            return ExecuteReader(query, null, readRow);
        }

        private List<Product> ExecuteReader(string query, Action<MySqlCommand> parameterize, Func<MySqlDataReader, Product> readRow)
        {
            var result = new List<Product>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    parameterize?.Invoke(cmd);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(readRow(reader));
                        }
                    }
                }
            }
            return result;
        }

        private Product ExecuteReaderSingle(string query, Action<MySqlCommand> parameterize, Func<MySqlDataReader, Product> readRow)
        {
            Product result = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    parameterize(cmd);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = readRow(reader);
                        }
                    }
                }
            }
            return result;
            };
        }

        private void AddProductParameters(MySqlCommand cmd, Product product)
        {
            cmd.Parameters.AddWithValue("@tov_name", product.Name);
            cmd.Parameters.AddWithValue("@quantity", product.Quantity);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@id_postach", product.Postachalnik);
        }
    }
}

