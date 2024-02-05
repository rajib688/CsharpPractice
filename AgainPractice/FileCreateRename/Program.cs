// See https://aka.ms/new-console-template for more information
using System.IO;

Console.WriteLine("Hello, World!");


string path = @"H:\\GitHub\\CsharpPractice\\AgainPractice\\FileCreateRename\Content.txt";
string newpath = @"H:\\GitHub\\CsharpPractice\\AgainPractice\\FileCreateRename\ReContent.txt";

//File.Create(path);

using FileStream filestrean = new FileStream(path, FileMode.Open);
using FileStream newfileStream = new FileStream(newpath, FileMode.OpenOrCreate);

for (int i = 0; i < (int)filestrean.Length; i++)
{
    filestrean.Seek(-i, SeekOrigin.End);
    newfileStream.WriteByte((byte) filestrean.ReadByte());
}

filestrean.Flush();
newfileStream.Flush();

filestrean.Dispose();
newfileStream.Dispose();

File.Delete(path);
File.Move(newpath, path);
