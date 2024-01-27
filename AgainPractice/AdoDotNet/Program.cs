// See https://aka.ms/new-console-template for more information
using AdoDotNetExample;

Console.WriteLine("Hello, World!");

string _connectionString = @"Server=DESKTOP-K32T5PF\SQLEXPRESS; Database=AgainPractice; User Id =Rajib; Password=12345; ";

DataHelper dataHelper = new DataHelper(_connectionString);

CommonDatahelper commonDatahelper = new CommonDatahelper(_connectionString);

//dataHelper.InsertData();
//Console.WriteLine("Insert Done");

while (true)
{
    Console.WriteLine("Enter your Name : ");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter your Cgpa : ");
    decimal Cgpa = decimal.Parse(Console.ReadLine());
    DateTime DateOfBirth = DateTime.Now;
    Guid StudentId = Guid.NewGuid();
    Console.WriteLine("Enter your IsActive : ");
    bool IsActive = bool.Parse(Console.ReadLine());


    List<Dictionary<string, object>> parameters = new List<Dictionary<string, object>>();

    parameters.Add(new Dictionary<string, object> { { "Name", Name } });
    parameters.Add(new Dictionary<string, object> { { "Cgpa", Cgpa } });
    parameters.Add(new Dictionary<string, object> { { "DateOfBirth", DateOfBirth } });
    parameters.Add(new Dictionary<string, object> { { "StudentId", StudentId } });
    parameters.Add(new Dictionary<string, object> { { "IsActive", IsActive} });


   // List<string> InsertData = string.Format(@"Insert into Student(Name,Cgpa,DateofBirth,StudentId, IsActive) values(@Name, @Cgpa, @DateOfBirth, @StudentId, @IsActive)";

   //commonDatahelper.MultiWriteOperation(InsertData, parameters);

}




/*
Console.WriteLine("Enter your Name : ");
string Name = Console.ReadLine();
Console.WriteLine("Enter your Cgpa : ");
decimal Cgpa = decimal.Parse(Console.ReadLine());
DateTime DateOfBirth = DateTime.Now;
Guid StudentId = Guid.NewGuid();
Console.WriteLine("Enter your IsActive : ");
bool IsActive = bool.Parse(Console.ReadLine());

Dictionary<string, object> parameters = new Dictionary<string, object>();

parameters.Add("Name", Name);
parameters.Add("Cgpa", Cgpa);
parameters.Add("DateOfBirth", DateOfBirth);
parameters.Add("StudentId", StudentId);
parameters.Add("IsActive", IsActive);

string InsertData = @"Insert into Student(Name,Cgpa,DateofBirth,StudentId, IsActive) values(@Name, @Cgpa, @DateOfBirth, @StudentId, @IsActive)";

string InsertSql = @"Insert into Student(Name, Cgpa, DateOfBirth, StudentId, IsActive)
values('Luck1', '4.21', '1999-12-31', '4765B14A-8EFA-4BF0-8ED2-D90BF12309E2','1')";

string UpdateSql = @"Update Student set Name = 'Mehedi', Cgpa = '4.52' where Id = 9";

string DeleteSql = "Delete from Student Where Id = 4";

commonDatahelper.WriteOperation(InsertData, parameters);
Console.WriteLine("Update Completed");


string SqlRead = "select * from Student";
//commonDatahelper.ReadOperation(SqlRead);

List<Dictionary<string, object>> data = commonDatahelper.ReadOperationdynamic(SqlRead, parameters);
foreach (Dictionary<string, object> item in data)
{
	foreach (var key in item.Keys)
	{
        Console.Write($"{key}:{item[key]}, ");
    }
    Console.WriteLine();
}

*/


