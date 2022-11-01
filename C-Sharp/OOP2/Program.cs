using OOP2;
using OOP2.Abstraction;
using OOP2.Encapsulation;
using OOP2.Polymophism;
using Teacher = OOP2.Abstraction.Teacher;

Teacher teacher = new Teacher();
teacher.name = "MD Rajib Rari";
teacher.Age = 23;

Teacher teacher1 = new Teacher();
teacher.name = "MD Rajib Rari";
teacher.Age = 20;

MemberShip memberShip = new MemberShip();
memberShip.EnrolTeacher(teacher);

Consultant consultant = new Consultant();
memberShip.EnrolTeacher(consultant);

SuperManTeacher superMan = new SuperManTeacher();
memberShip.EnrolTeacher(superMan);


Vehicle vehicle = new Vehicle();
Vehicle Vehicle1 = new Bus();
Vehicle1.Start();

