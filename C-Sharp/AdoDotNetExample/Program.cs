

using AdoDotNetExample;

string _connectionString = "Server=DESKTOP-K32T5PF; Database=CsharpB11; User Id=CsharpB11; Password=12345;";

DataHelper dataHelper = new DataHelper(_connectionString);

string name = Console.ReadLine();
decimal Gpa = decimal.Parse(Console.ReadLine());
DateTime BOD = DateTime.Parse(Console.ReadLine());
Guid StudentID = Guid.Parse(Console.ReadLine());
bool IsActive = bool.Parse(Console.ReadLine());


Dictionary<string, object> parameter = new Dictionary<string, object>();

parameter.Add("Name", name);
parameter.Add("Gpa", Gpa);
parameter.Add("DateOfBirth", BOD);
parameter.Add("StudentID", StudentID);
parameter.Add("IsActive", IsActive);


string SqlInsert = "Insert into Student([Name],gpa,DateOfBirth,StudentID,IsActive)values(@Name, @Gpa, @DateOfBirth, @StudentID,@IsActive)";
string SqlUpdate = "Update Student set Name='Tanjila',gpa=4.06 where id=11 ";
string SqlDelete = "Delete From Student where Id=11";


//dataHelper.WriteOperation(SqlInsert, parameter);



//string SqlRead = "Select * from Student";

//List<Dictionary<string, object>> data = dataHelper.ReadOperation(SqlRead);
//foreach (Dictionary<string, object> item in data)
//{
//	foreach (var Key in item.Keys)
//	{
//		Console.Write($"{Key}:{item[Key]}, " );
//	}
//	Console.WriteLine();
//}

Console.WriteLine("Complete");


//dataHelper.InsertData();
//Console.WriteLine("Insert Data");

//dataHelper.UpdateData();
//Console.WriteLine("Update Complete");

