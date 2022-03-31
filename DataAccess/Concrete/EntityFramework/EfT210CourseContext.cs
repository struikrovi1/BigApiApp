using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfT210CourseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MedDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Category> Category { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseSpecification> CourseSpecifications { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<LessonVideo> LessonVideos { get; set; }


        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Specification> Specifications { get; set; }


    }
}
