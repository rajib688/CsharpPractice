// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!");



Student student = new Student();
student.Name = "Rajib";
student.Roll = 20;
student.SetRoll(12);

Student student1 = new Student("Rajib",2,24);

//foreach (var item in student1)
//{
//    Console.WriteLine(item);
//}

Teacher teacher = new Teacher();
teacher.Name = "Rajib Rari";
teacher.SetWeight(90);
teacher.Height = 8;
teacher.Salary = "4000";
teacher.Address = "Dhaka";
teacher.Talk("Hello Dear X. ");