using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    public class SchoolContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=School;Trusted_Connection=True;");
        }

        public void AddStudent(string name) {
            var student = new Student() { Name = name,
            CreatedTimestamp = DateTime.Now};

            Students.Add(student);
            SaveChanges();
        }

        public void AddCourse(string name)
        {
            var course = new Course() { CourseName = name };

            Courses.Add(course);
            SaveChanges();
        }

        public void DisplayStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine("{0} - {1}", student.Id, student.Name);
            }

            Console.WriteLine();
        }

        public void DisplayCourses()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine("{0} - {1}", course.Id, course.CourseName);
            }

            Console.WriteLine();
        }

        public void UpdateStudent(int id, string name) 
        {
           var student = Students.Where(s => s.Id.Equals(id)).FirstOrDefault();

            student.Name = name;
            Students.Update(student);
            SaveChanges();
        }

        public void UpdateCourse(string oldName, string newName)
        {
            var course = Courses.Where(s => s.CourseName.Equals(oldName)).FirstOrDefault();

            course.CourseName = newName;
            Courses.Update(course);
            SaveChanges();
        }

        public void DeleteStudent(string name)
        {
            var student = Students.Where(s => s.Name.Equals(name)).FirstOrDefault();

            Students.Remove(student);
            SaveChanges();
        }

        public void DeleteCourse(string name)
        {
            IQueryable<Course> courses = Courses.Where(s => s.CourseName.Equals(name));

            Course course = courses.FirstOrDefault();

            Courses.Remove(course);
            SaveChanges();
        }
    }
}
