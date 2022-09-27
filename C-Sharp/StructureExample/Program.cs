// See https://aka.ms/new-console-template for more information


using StructureExample;

Student s = new Student();
s.name = "Rajib Rari";

Student s2 = s;

s2.name = "Rajib";

Console.WriteLine(s.name);
Console.WriteLine(s2.name);


Teacher Teacher = new Teacher();
Teacher.name = "Hasan";

Teacher Teacher1 = Teacher;
Teacher1.name = "Rafiq";

Console.WriteLine(Teacher.name);
Console.WriteLine(Teacher1.name);


void test(Teacher teacher)
{
    teacher.name = "Kopal Dash";
}

test(Teacher);

Console.WriteLine(Teacher.name);