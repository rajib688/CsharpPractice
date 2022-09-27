// See https://aka.ms/new-console-template for more information


char a = 'র';

string s = "Hello World";
Console.WriteLine(s);
s += "from C#";
string t = "Hello world from c#";

string p = string.Empty;
if (string.IsNullOrWhiteSpace(p))
{

}

Console.WriteLine(t.IndexOf("#"));
Console.WriteLine(t.IndexOfAny(new char[] {'#','f'}));

string substring = t.Substring(5,9);

Console.WriteLine(substring);

string result = string.Join(' ', "Hello", "World");
Console.WriteLine(result);

string text = "This is a big text";
Console.WriteLine(text.PadLeft(24,'*'));

string text2 = "   Hello World";
Console.WriteLine(text2.Trim());

string text3 = "***Hello World*?*";
Console.WriteLine(text3.Trim('*','?'));

