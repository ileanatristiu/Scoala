using System;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            SchoolContext context = new SchoolContext();

            /*context.AddStudent("Ionescu");
            context.AddStudent("Creanga");

            context.AddCourse("Testing");
            context.AddCourse(".NET");*/

            context.DisplayStudents();
            context.DisplayCourses();

            //context.UpdateStudent(1, "Popecu update");
            //context.UpdateCourse(".NET", ".NET Core");

            //context.DeleteStudent("Popecu update");

            context.AddStudent("test");
            

            context.DisplayStudents();
            context.DisplayCourses();

            Console.ReadLine();
        }
    }
}
