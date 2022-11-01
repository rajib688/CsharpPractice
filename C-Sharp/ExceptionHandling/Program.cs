// See https://aka.ms/new-console-template for more information


//Exception ex;
//InvalidCastException Exce;

using ExceptionHandling;


try
{
    CourseManagement courseManagement = new CourseManagement();
    courseManagement.CreateCourse("C#");
}
catch (DuplicateException de)
{
    Console.WriteLine(de.Message);
}
catch(Exception ex)
{
    Console.WriteLine("There was a problem");
}
finally
{
    Console.WriteLine("Program Ended......");
}



//var x = 5;
//if (x>10)
//{

//}
//else if(x<0)
//{

//}
//else
//{

//}