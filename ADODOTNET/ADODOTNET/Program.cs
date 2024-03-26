// See https://aka.ms/new-console-template for more information
using ADODOTNET;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");


String _connectionString = "Server = DESKTOP-K32T5PF; Database = Dream-Limited; User Id =sa; Password =Rajib@2024;";
DataHelper dataHelper = new DataHelper(_connectionString);

string QueryString = "Insert Into Student(Name, Weight)values('Eyashin',70)";
//string QueryString = "InsertData"; Store procedure name using 

dataHelper.WriteOperation(QueryString);