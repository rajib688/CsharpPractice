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

        private SqlCommand CreateSqlCommand(string Sql, Dictionary<string, object> parameter)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();


            SqlCommand sqlCommand = new SqlCommand(Sql, sqlConnection);

            foreach (var item in parameter)
            {
                sqlCommand.Parameters.Add(new SqlParameter(item.Key, item.Value));
            }
            return sqlCommand;
        }
        public void WriteOperation(string Sql, Dictionary<string, object> parameter)
        {
            using SqlCommand sqlCommand = CreateSqlCommand(Sql, parameter);

            sqlCommand.ExecuteNonQuery();
        }

        public void MultiWriteOperation(List<string> Sqls, List<Dictionary<string, object>> parameter)
        {
            using SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();

            using SqlTransaction Transaction = sqlConnection.BeginTransaction();


            //SqlCommand sqlCommand = CreateSqlCommand("", new Dictionary<string, object>());
            //SqlTransaction Transaction = sqlCommand.Connection.BeginTransaction();

            try
            {
                for (int i = 0; i < Sqls.Count; i++)
                {
                    SqlCommand Command = CreateSqlCommand(Sqls[i], parameter[i]);
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
            }
            catch (Exception ex)
            {
                Transaction.Rollback();
            }
        }


        public List<Dictionary<string, object>> ReadOperation(string Sql, Dictionary<string, object> parameter)
        {
            using SqlCommand sqlCommand = CreateSqlCommand(Sql, parameter);

            using SqlDataReader reader = sqlCommand.ExecuteReader();

            //Dictionary<string, object>[] rows = new Dictionary<string, object>[100];

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            
            while(reader.Read())
            {
                //int ID = (int)reader["ID"];
                //string Name = (string)reader["Name"];
                //decimal Gpa = (decimal)reader["Gpa"];
                //DateTime BOD = (DateTime)reader["DateOfBirth"];
                //Guid StudentID = (Guid)reader["StudentID"];
                //bool IsActive = (bool)reader["IsActive"];
                //Console.WriteLine($"ID:{ ID},  Name:{Name},  Gpa:{Gpa},  BOD:{BOD},  StudentID:{StudentID},  IsActive:{IsActive}");

                Dictionary<string, object> row = new Dictionary<string, object>();
                for (int i=0; i<reader.FieldCount; i++)
                {
                    row.Add(reader.GetName(i), reader.GetValue(i));
                }
                rows.Add(row);
            }
            return rows;
        }
    }
}