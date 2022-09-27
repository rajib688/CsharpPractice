// See https://aka.ms/new-console-template for more information


using EnumExample;

string option = Console.ReadLine();

Console.WriteLine((int)RegisterTypes.Passport);

if (option == RegisterTypes.Name.ToString())
{
    Console.WriteLine("Enter your name");
}
else if (option == RegisterTypes.VoterId.ToString())
{
    Console.WriteLine("Enter your voter ID");
}
else if (option == RegisterTypes.Passport.ToString())
{
    Console.WriteLine("Enter your passport number");
}

