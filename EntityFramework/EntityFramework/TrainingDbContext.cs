using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;
        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-K32T5PF; Database=CsharpB11; User Id=CsharpB11; Password=12345;";
            _assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEnrollment>().ToTable("CourseEnrollments");
            modelBuilder.Entity<CourseEnrollment>().HasKey(cs => new { cs.CourseId, cs.StudentId });

            //One to many
            modelBuilder.Entity<Course>()
                .HasMany(p => p.topics)
                .WithOne(i => i.Course);

            //Many to many 
            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(pc => pc.Course)
                .WithMany(p => p.CourseRegitrations)
                .HasForeignKey(pc => pc.CourseId);

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(pc => pc.Student)
                .WithMany(c => c.StudentEnrollments)
                .HasForeignKey(pc => pc.StudentId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
