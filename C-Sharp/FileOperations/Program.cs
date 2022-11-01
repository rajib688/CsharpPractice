// See https://aka.ms/new-console-template for more information

using System.Text;

string path = "F:\\RAJIB__Books\\Dot Net\\Dev Skill\\C-Sharp\\FileOperations\\demo.txt";
var content = "How are you ?";

//File.WriteAllText(path, content);

/*
using FileStream stream = File.Create(path);
byte[] data = Encoding.UTF8.GetBytes(content);
foreach (byte b in data)
{
    stream.WriteByte(b);
}
stream.Flush();

*/

/*
if (File.Exists(path))
{
    string text = File.ReadAllText(path);
}

File.Delete(path);

Console.WriteLine();

*/
/*

FileInfo fileInfo = new FileInfo(path);
if (!fileInfo.Exists)
{
    fileInfo.Create();
}
*/


string anothrepath = Directory.GetCurrentDirectory();
DirectoryInfo Folder = Directory.GetParent(anothrepath);
string location = Folder.Parent.Parent.FullName;
string fullpath = Path.Combine(location, "demo.txt");


var folderPath = Path.Combine(location, "test");

//Directory.CreateDirectory(folderPath);

if (Directory.Exists(folderPath))
    Directory.Delete(folderPath);


DirectoryInfo directory = new DirectoryInfo(location);
FileInfo[] files = directory.GetFiles();
foreach (var file in files)
{
    Console.WriteLine(file.Name);
    Console.WriteLine(Path.GetExtension(file.Name));
}

DirectoryInfo[] chilFolders = directory.GetDirectories();
foreach (var chilFolder in chilFolders)
{
    Console.WriteLine(chilFolder.Name);
}

Console.WriteLine(Path.Combine(location, "test"));

Console.WriteLine(Path.GetExtension(fullpath));


//Old using Statement
using (FileStream fs1 = File.Open(fullpath, FileMode.Open));
{

}

//New using Statement
using FileStream fs = File.Open(fullpath, FileMode.Open);
