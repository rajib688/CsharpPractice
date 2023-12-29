


//string line = Console.ReadLine();

//Console.WriteLine(line);

//while (true)
//{
//    char c = (char)Console.Read();
//	if (c == 'x')
//	{
//		break;
//	}
//    Console.WriteLine(c);
//}

//while (true)
//{
//	ConsoleKeyInfo c = Console.ReadKey();
//	if (c.KeyChar == 'x' )
//	{
//		break;
//	}
//    Console.WriteLine(c.KeyChar);
//}


//string input = Console.ReadLine();
//string[] parts = input.Split(' ');
//for (int i = 0; i < parts.Length; i++)
//{
//    Console.WriteLine();
//    Console.WriteLine(parts[i] + " ");
//}

while (true)
{
    Console.Write("Enter your Input : ");

    int x = int.Parse(Console.ReadLine());

    //tanari operator

    string message = x > 5 ? $"{x}" + " Is Greater Than 5" : $"{x}" + " Is not Greater Than 5";

    Console.WriteLine(message);
}
