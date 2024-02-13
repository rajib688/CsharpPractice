// See https://aka.ms/new-console-template for more information


using ExceptionHandling;

Console.WriteLine("Hello, World!");

try
{
    CourseManagement courseManagement = new CourseManagement();
    courseManagement.CreateCourse("C#");
}
catch (DuplicateException de)
{
    Console.WriteLine(de.Message);
}
catch (Exception ex)
{
    Console.WriteLine("There was a problem");
}
finally
{
    Console.WriteLine("Program End");
}