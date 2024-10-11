using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager manager = new CourseManager();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Course Management System");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. View All Courses");
                Console.WriteLine("3. Update a Course");
                Console.WriteLine("4. Delete a Course");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an Option");
                var option = Console.ReadLine();
                while (option != null)
                {
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Enter Course Id");
                            string CourseId = Console.ReadLine();

                            Console.WriteLine("Enter Course Title");
                            string Title = Console.ReadLine();

                            Console.WriteLine("Enter Course Duration");
                            string Duration = Console.ReadLine();

                            Console.WriteLine("Enter Course Price");
                            decimal Price = Console.ReadLine();

                            manager.CreateCourse(CourseId, Title, Duration, Price);
                            break;

                        case "2":
                            manager.ReadCourses();

                            break;

                        case "3":
                            Console.WriteLine("Enter Course Id");
                            string CourseId = Console.ReadLine();

                            manager.DeleteCourse(CourseId);
                            break;

                        case "4":
                            Console.WriteLine("Enter Course Id");
                            string CourseId = Console.ReadLine();
                            manager.DeleteCourse(CourseId);
                            break;

                        case "5":
                            bool exit = true;
                            break;

                        default:
                            Console.WriteLine("Choose correct option");


                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
        }
}
