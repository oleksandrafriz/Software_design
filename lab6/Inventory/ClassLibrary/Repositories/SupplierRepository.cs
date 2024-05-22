using System;
using System.Collections.Generic;
using ClassLibrary.Helpers;
using MySql.Data.MySqlClient;

namespace ClassLibrary
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly MySqlDbHelper _dbHelper;

        public SupplierRepository(string connectionString)
        {
            _dbHelper = new MySqlDbHelper(connectionString);
        }

        public List<Postachalnik> GetAllSuppliers()
        {
            const string query = "SELECT * FROM postachalnik";
            return _dbHelper.ExecuteReader(query, reader => new Postachalnik
            {
                Id = Convert.ToInt32(reader["id_postach"]),
                Name = reader["name_postach"].ToString(),
                Address = reader["address"].ToString(),
                PhoneNumber = reader["phone_number"].ToString(),
                CompanyName = reader["company_name"].ToString()
            });
        }
    }
}
