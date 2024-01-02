// See https://aka.ms/new-console-template for more information

using StructureExample;

Console.WriteLine("Hello, World!");

Student student = new Student();
student.Name = "Rajib Rari";

Student student1 = student;
student1.Name = "Tarek";

Console.WriteLine(student.Name);
Console.WriteLine(student1.Name);

Teacher teacher = new Teacher();
teacher.Name = "Rezaul";

Teacher teacher1 = teacher;
teacher1.Name = "Robiul";

Console.WriteLine(teacher.Name);
Console.WriteLine(teacher1.Name);

Teststudent(student);

Console.WriteLine(student.Name);

void Teststudent(Student student)
{
    student.Name = "Rakib";
}

Testteacher(teacher);

Console.WriteLine(teacher.Name);

void Testteacher(Teacher teacher)
{
    teacher.Name = "Rakib";
}