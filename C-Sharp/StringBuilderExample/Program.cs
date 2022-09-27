// See https://aka.ms/new-console-template for more information

using System.Text;

string text = "Hello World";

text = text + " From C#";

Char c = text[2];

StringBuilder sb = new StringBuilder();

Console.WriteLine(sb.Append(text));

Console.WriteLine(sb.AppendLine(" from C#"));
sb[2] = 'M';
Console.WriteLine(sb[2]);