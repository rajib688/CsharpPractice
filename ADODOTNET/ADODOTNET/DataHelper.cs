using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODOTNET
{
    public class DataHelper
    {
        private readonly string _connectionString;
        public DataHelper(string connectionString) 
        {
            _connectionString = connectionString;
        }
        public void WriteOperation(string Sql)
        {
            using SqlConnection _connection = new SqlConnection(_connectionString);
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            using SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Sql;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = _connection;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Insert Successfully");
        }
    }
}
