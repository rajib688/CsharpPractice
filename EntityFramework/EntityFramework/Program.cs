// See https://aka.ms/new-console-template for more information



using EntityFramework;
using Microsoft.EntityFrameworkCore;

TrainingDbContext trainingDbContext = new TrainingDbContext();
/*
Student student = new Student();
student.Name = "Morium";
student.Gpa = 4.50;
student.DateOfBirth = new DateTime(1999, 2, 3);
student.StudentID = Guid.NewGuid();
student.IsActive = false;
trainingDbContext.Students.Add(student);

Student OldStudent = trainingDbContext.Students.Where(x => x.Name.Contains("Rajib")).FirstOrDefault();

OldStudent.Gpa = 4.00;

Student Rakib = trainingDbContext.Students.Where(x => x.Id == 2).FirstOrDefault();

trainingDbContext.Students.Remove(Rakib);


trainingDbContext.SaveChanges();
*/
/*
Course course = new Course();
course.Fees = 25000;
course.Title = "C#";
course.topics = new List<Topic>();
course.topics.Add(new Topic(){ Description = "Getting Started"});
course.topics.Add(new Topic(){ Description = "Basic syntax"});

trainingDbContext.Courses.Add(course);

trainingDbContext.SaveChanges();
*/

/*
var oldCourse = trainingDbContext.Courses.Where(x => x.Id == 1).Include(y => y.topics ).FirstOrDefault();
oldCourse.Title = "C# Advance";

var topicToDelete = oldCourse.topics.Where(x => x.Description == "Basic syntax").FirstOrDefault();
oldCourse.topics.Remove(topicToDelete);

oldCourse.topics[0].Description = "Introduction";
oldCourse.topics.Add(new Topic() { Description = "Loops" });

trainingDbContext.SaveChanges();
*/

Course course = new Course();
course.Title = "C#";
course.Fees = 8000;
course.CourseRegitrations = new List<CourseEnrollment>();

Student student = new Student();
student.Name = "Rasedul";
student.Gpa = 4.50;
student.DateOfBirth = new DateTime(1999, 10, 10);
student.StudentID = Guid.NewGuid();
student.IsActive = true;

CourseEnrollment courseEnrollment = new CourseEnrollment();
courseEnrollment.Student = student;

course.CourseRegitrations.Add(courseEnrollment);
trainingDbContext.Courses.Add(course);
trainingDbContext.SaveChanges();
