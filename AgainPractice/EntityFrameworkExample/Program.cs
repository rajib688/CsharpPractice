// See https://aka.ms/new-console-template for more information


using EntityFrameworkExample;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

TrainingDbContext trainingDbContext = new TrainingDbContext();

/*
Student student = new Student();
Console.Write("Enter your Name : ");
string Name = Console.ReadLine();
student.Name = Name;
student.Cgpa = 4.06;
student.DateOfBirth = new DateTime(1999, 12, 31);
student.StudentId = Guid.NewGuid();
student.IsActive = true;

trainingDbContext.Students.Add(student);

//trainingDbContext.SaveChanges();

Student OldStudent = trainingDbContext.Students.Where(m => m.Name.Contains("Rajib Rari")).FirstOrDefault();

OldStudent.Cgpa = 5.20;

string sql = "select Id from Students where IsActive = 1";

Student Delete = trainingDbContext.Students.Where(m => m.Id == 2).FirstOrDefault();

trainingDbContext.Students.Remove(Delete);

trainingDbContext.SaveChanges();


Course course = new Course();

course.Title = "C#";
course.Fees = 4000;
course.Topics = new List<Topic>();
course.Topics.Add(new Topic { Description = "Getting Started" });
course.Topics.Add(new Topic { Description = "Basic Syntax" });
trainingDbContext.courses.Add(course);
trainingDbContext.SaveChanges();


var OldCourse = trainingDbContext.courses.Where(x=>x.Id == 1).Include( y => y.Topics).FirstOrDefault();

var topicToDelete = OldCourse.Topics.Where(x => x.Description == "Basic Syntax").FirstOrDefault();

OldCourse.Topics.Remove(topicToDelete);

OldCourse.Topics[0].Description = "Introduction";

OldCourse.Topics.Add(new Topic() { Description = "Loops" });

trainingDbContext.SaveChanges();
*/


Course course = new Course();
course.Title = "Php";
course.Fees = 5000;
course.CourseRegitrations = new List<CourseEnrollment>();


Student student = new Student();
student.Name = "Rafiya";
student.Cgpa = 4.35;
student.DateOfBirth = new DateTime(2000, 01, 01);
student.StudentId = Guid.NewGuid();
student.IsActive = true;
student.StudentEnrollments = new List<CourseEnrollment>();

CourseEnrollment courseEnrollment = new CourseEnrollment();
courseEnrollment.Student = student;

course.CourseRegitrations.Add(courseEnrollment);

trainingDbContext.courses.Add(course);

trainingDbContext.SaveChanges();

Console.WriteLine("Operation Completed..!!");