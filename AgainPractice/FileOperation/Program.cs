// See https://aka.ms/new-console-template for more information

using System.Text;


Console.WriteLine("Hello, World!");

string PathName = "H:\\GitHub\\CsharpPractice\\Demo.txt";

var content = "How are you Mrs. Rajib Rari";

//static Method
//File.WriteAllText(Path, content );  // text file put kora
//File.AppendAllText(Path, content );   // add text before text 
//File.WriteAllText(Path, content );  // override before text


/*
using FileStream fileStream = File.Create(Path);
byte[] data = Encoding.UTF8.GetBytes(content);
foreach (var b in data)
{
    fileStream.WriteByte(b);
}

fileStream.Flush();


File.Delete(Path);

if (File.Exists(Path))
{
    string text = File.ReadAllText(Path);
}

//string[] Lines = File.ReadAllLines(Path);   // array text lines 


FileInfo fileInfo = new FileInfo(Path);
if(!fileInfo.Exists)
{
    fileInfo.Create();
}

Console.WriteLine();
*/


//static method

string AnotherPath = Directory.GetCurrentDirectory();

DirectoryInfo folder = Directory.GetParent(AnotherPath);

string location = folder.Parent.Parent.FullName;

string fullPath = Path.Combine(location, "demo.txt");


var folderPath = Path.Combine(location, "Test");
//Directory.CreateDirectory(folderPath);
if (Directory.Exists(folderPath))
{
    Directory.Delete(folderPath);
}

DirectoryInfo directoryInfo = new DirectoryInfo(location);

FileInfo[] files = directoryInfo.GetFiles();

foreach (var file in files)
{
    Console.WriteLine(file.Name); /*File check*/
}

DirectoryInfo[] childfolders = directoryInfo.GetDirectories();

foreach (var childfolder in childfolders)
{
    Console.WriteLine(childfolder.Name);
}

Console.WriteLine(Path.Combine(location, "text", "text1"));

Console.WriteLine(Path.GetExtension(PathName));

