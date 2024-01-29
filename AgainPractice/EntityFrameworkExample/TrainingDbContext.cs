using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public TrainingDbContext()
        {

            _connectionString = "Data Source=DESKTOP-K32T5PF; Initial Catalog=AgainPractice;User ID=sa; Password=Rajib@2024; Trust Server Certificate=True";

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
            modelBuilder.Entity<CourseEnrollment>().HasKey( cs => new { cs.CourseId, cs.StudentId} );

            modelBuilder.Entity<Course>()
                 .HasMany(p => p.Topics)   /*One to Many Relation */
                 .WithOne(i => i.Course);


            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(pc => pc.Course)
                .WithMany(p => p.CourseRegitrations)  /*Many to Many Relation*/
                .HasForeignKey(pc => pc.CourseId);

            modelBuilder.Entity<CourseEnrollment>()
                .HasOne(pc => pc.Student)
                .WithMany(c => c.StudentEnrollments) /*Many to Many Relation*/
                .HasForeignKey(pc => pc.StudentId);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> courses { get; set; }

    }
}
