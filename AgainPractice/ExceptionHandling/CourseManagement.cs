using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CourseManagement
    {
        List<string> courses = new List<string>();
        public CourseManagement() 
        {
            courses.Add("C#");
        }
        //List<string> courses;
        public void CreateCourse(string title)
        {
            try
            {
                var Count = courses.Where(x => x == title).ToList().Count();

                if (Count > 0)
                {
                    throw new DuplicateException("Course name already exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem in checking existing courses", ex);
            }
        }
    }
}
