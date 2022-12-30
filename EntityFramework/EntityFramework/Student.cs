using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(10), MinLength(5)]
        public string Name { get; set; }
        public double Gpa { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid StudentID { get; set; }
        public bool IsActive { get; set; }
        public List<CourseEnrollment> StudentEnrollments { get; set; }
    }
}
