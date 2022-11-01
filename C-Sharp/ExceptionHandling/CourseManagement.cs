using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class CourseManagement
    {
        //List<string> courses;

        List<string> courses = new List<string>();

        public CourseManagement()
        {
            courses.Add("C#");
        }
        public void CreateCourse(string title)
        {
            try
            {
                var count = courses.Where(x => x == title).ToList().Count();
                if (count > 0)
                {
                    throw new DuplicateException("Course name already exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem in Checking existing course", ex);
            }
        }
    }
}
