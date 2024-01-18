using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetExample
{
    public class DataHelper
    {
        private readonly string _connectionString;
        public DataHelper(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void InsertData()
        {

            //using SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = _connectionString;
            //connection.Open();

            //string Sql = @"Insert into Student(Name, Cgpa, DateOfBirth, StudentId, IsActive)
            //values('Luck1', '4.21', '1999-12-31', '4765B14A-8EFA-4BF0-8ED2-D90BF12309E2','1')";

            //using SqlCommand cmd = new SqlCommand(Sql, connection);
            //cmd.ExecuteNonQuery();

        }

        public void UpdateData()
        {
            //using SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = _connectionString;
            //connection.Open();

            //string Sql = @"Update Student set Name = 'Mehedi', Cgpa = '4.52' where Id = 9";

            //using SqlCommand cmd = new SqlCommand(Sql, connection);
            //cmd.ExecuteNonQuery();
        }

    }
}
