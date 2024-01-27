using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetExample
{
    public class CommonDatahelper
    {
        private readonly string _connectionString;
        public CommonDatahelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlCommand CreateSqlCommand(string Sql, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(Sql, connection);
            foreach (var parameter in parameters)
            {
                cmd.Parameters.Add(new SqlParameter(parameter.Key, parameter.Value));
            }
            return cmd;
        }


        public void WriteOperation(string Sql, Dictionary<string, object> parameters)
        {
            using SqlCommand cmd = CreateSqlCommand(Sql, parameters);
            cmd.ExecuteNonQuery();
        }


        public void MultiWriteOperation(List<string> Sqls, List<Dictionary<string, object>> parameters)
        {
            using SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            //SqlCommand cmd = CreateSqlCommand("", new Dictionary<string, object>());

            using SqlTransaction Transaction = connection.BeginTransaction();
            try
            {
                for (int i = 0; i < Sqls.Count; i++)
                {
                    SqlCommand command = CreateSqlCommand(Sqls[i], parameters[i]);
                    command.ExecuteNonQuery();
                }
                Transaction.Commit();
                Console.WriteLine("Transaction committed successfully");
            }
            catch (Exception ex)
            {
                Transaction.Rollback();
                Console.WriteLine($"Transaction rolled back due to an error: {ex.Message}");
            }

        }


        public void ReadOperation(string Sql, Dictionary<string, object> parameters)
        {
            using SqlCommand cmd = CreateSqlCommand(Sql, parameters);

            using SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int Id = (int)reader["Id"];
                string Name = (string)reader["Name"];
                decimal Cgpa = (decimal)reader["Cgpa"];
                DateTime BOD = (DateTime)reader["DateOfBirth"];
                Guid SID = (Guid)reader["StudentId"];
                bool IsActive = (bool)reader["IsActive"];

              Console.WriteLine($"Id: {Id}, Name: {Name}, Cgpa: {Cgpa}, BOD: {BOD}, Student: {SID}, IsActive: {IsActive}");

            }

        }

        public List<Dictionary<string, object>> ReadOperationdynamic(string Sql, Dictionary<string, object> parameters)
        {
            using SqlCommand cmd = CreateSqlCommand(Sql, parameters);

            using SqlDataReader reader = cmd.ExecuteReader();
            //Dictionary<string, object> rows = new Dictionary<string, object>(); use array
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                rows.Add(row);
            }
            return rows;
        }
    }
}
