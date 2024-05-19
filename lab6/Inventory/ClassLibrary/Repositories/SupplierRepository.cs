using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly string _connectionString;

        public SupplierRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public List<Postachalnik> GetAllSuppliers()
        {
            const string query = "SELECT * FROM postachalnik";
            return ExecuteReader(query, reader => new Postachalnik
            {
                Id = Convert.ToInt32(reader["id_postach"]),
                Name = reader["name_postach"].ToString(),
                Address = reader["address"].ToString(),
                PhoneNumber = reader["phone_number"].ToString(),
                CompanyName = reader["company_name"].ToString()
            });
        }

        private List<Postachalnik> ExecuteReader(string query, Func<MySqlDataReader, Postachalnik> readRow)
        {
            var result = new List<Postachalnik>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
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
    }
}
