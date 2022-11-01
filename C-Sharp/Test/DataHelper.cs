using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DataHelper
    {
        string _connnectionString = "Data Source= DESKTOP-K32T5PF; Initial Catalog= CsharpB11; User Id= CsharpB11; Password=12345;";

        public void DataInsert()
        {
            SqlConnection sqlConnection = new SqlConnection(_connnectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Insert into Student([Name],gpa,DateOfBirth,StudentID,IsActive)values('Rakibul',3.88,'2021-05-21','F7F6657F-ECC3-4754-8BF6-75E6D50F9102',1)", sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
