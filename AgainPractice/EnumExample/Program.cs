// See https://aka.ms/new-console-template for more information
using EnumExample;

Console.WriteLine("Hello, World!");

string option = Console.ReadLine();

if (option == RegisterTypes.Name.ToString())
{
    Console.WriteLine("Please Enter Your Name : ");
}
else if (option == RegisterTypes.VoterId.ToString())
{
    Console.WriteLine("Please Enter Your VoterId : ");
}