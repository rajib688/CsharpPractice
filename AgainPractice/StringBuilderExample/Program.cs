// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string txt = "Hello World";

txt = txt + " From C#";
Console.WriteLine(txt);


StringBuilder sb = new StringBuilder();
sb.Append(txt);
sb.AppendLine(" From C#");
sb[2] = 'M';