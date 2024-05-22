using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helpers
{
    public class MySqlDbHelper
    {
        private readonly string _connectionString;

        public MySqlDbHelper(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        private void ExecuteCommand(string query, Action<MySqlCommand> parameterize, Action<MySqlCommand> execute)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    parameterize(cmd);
                    execute(cmd);
                }
            }
        }

        public void ExecuteNonQuery(string query, Action<MySqlCommand> parameterize)
        {
            ExecuteCommand(query, parameterize, cmd => cmd.ExecuteNonQuery());
        }

        public List<T> ExecuteReader<T>(string query, Func<MySqlDataReader, T> readRow)
        {
            return ExecuteReader(query, cmd => { }, readRow);
        }

        public List<T> ExecuteReader<T>(string query, Action<MySqlCommand> parameterize, Func<MySqlDataReader, T> readRow)
        {
            var result = new List<T>();
            ExecuteCommand(query, parameterize, cmd =>
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(readRow(reader));
                    }
                }
            });
            return result;
        }

        public T ExecuteReaderSingle<T>(string query, Action<MySqlCommand> parameterize, Func<MySqlDataReader, T> readRow)
        {
            T result = default;
            ExecuteCommand(query, parameterize, cmd =>
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = readRow(reader);
                    }
                }
            });
            return result;
        }
    }
}