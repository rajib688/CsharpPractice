// See https://aka.ms/new-console-template for more information

string line = Console.ReadLine();

Console.WriteLine(line);

char r = 'P';

Console.WriteLine(r);

//while(true)
//{
//    char c = (char)Console.Read();
//	if (c=='x')
//	{
//		break;
//	}
//	Console.WriteLine(c);
//}


//while (true)
//{
//	ConsoleKeyInfo c = Console.ReadKey();

//    Console.WriteLine(c.KeyChar);
//}


string Input = Console.ReadLine();

string[] parts = Input.Split(' ');
for (int i = 0; i < parts.Length; i++)
{
    Console.WriteLine(parts[i]);
}