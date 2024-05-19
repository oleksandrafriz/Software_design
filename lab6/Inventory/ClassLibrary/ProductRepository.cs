using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class ProductRepository : IProductRepository
    {
        private string connectionString;

        public ProductRepository()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void AddProduct(Product product)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "INSERT INTO tovars (tov_name, quantity, price, id_postach) VALUES (@tov_name, @quantity, @price, @id_postach)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@tov_name", product.Name);
                    cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@id_postach", product.Postachalnik);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "UPDATE tovars SET tov_name = @tov_name, quantity = @quantity, price = @price, id_postach = @id_postach WHERE id_tovar = @id_tovar";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_tovar", product.Id);
                    cmd.Parameters.AddWithValue("@tov_name", product.Name);
                    cmd.Parameters.AddWithValue("@quantity", product.Quantity);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@id_postach", product.Postachalnik);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int productId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "DELETE FROM tovars WHERE id_tovar = @id_tovar";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_tovar", productId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = @"
            SELECT 
                t.id_tovar, 
                t.tov_name, 
                t.quantity, 
                t.price, 
                p.name_postach 
            FROM 
                tovars t
            JOIN 
                postachalnik p ON t.id_postach = p.id_postach";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                Id = Convert.ToInt32(reader["id_tovar"]),
                                Name = reader["tov_name"].ToString(),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                Price = Convert.ToDecimal(reader["price"]),
                                Postachalnik = reader["name_postach"].ToString()
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }

        public Product GetProductById(int productId)
        {
            Product product = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM tovars WHERE id_tovar = @id_tovar";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_tovar", productId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
                            {
                                Id = Convert.ToInt32(reader["id_tovar"]),
                                Name = reader["tov_name"].ToString(),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                Price = Convert.ToDecimal(reader["price"]),
                                Postachalnik = reader["id_postach"].ToString()
                            };
                        }
                    }
                }
            }
            return product;
        }

        public List<Product> SearchProductsByName(string name)
        {
            var products = new List<Product>();
            using (var connection = GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM tovars WHERE tov_name LIKE @name";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                Id = Convert.ToInt32(reader["id_tovar"]),
                                Name = reader["tov_name"].ToString(),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                Price = Convert.ToDecimal(reader["price"]),
                                //Postachalnik = reader["name_postach"].ToString()
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
    }
}
