using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Course Code: ");
                            string courseCode = Console.ReadLine();

                            Console.Write("Course Name: ");
                            string courseName = Console.ReadLine();

                            Console.Write("Credits: ");
                            int credits = int.Parse(Console.ReadLine());

                            Console.Write("Capacity: ");
                            int capacity = int.Parse(Console.ReadLine());

                            Console.Write("Prerequisites (comma separated): ");
                            List<string> prereq =
                                Console.ReadLine()
                                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                                .Select(p => p.Trim())
                                .ToList();

                            system.AddCourse(courseCode, courseName, credits, capacity, prereq);
                            break;

                        case "2":
                            Console.Write("Student ID: ");
                            string studentId = Console.ReadLine();

                            Console.Write("Student Name: ");
                            string studentName = Console.ReadLine();

                            Console.Write("Major: ");
                            string major = Console.ReadLine();

                            Console.Write("Max Credits: ");
                            int maxCredits = int.Parse(Console.ReadLine());

                            Console.Write("Completed Courses (comma separated): ");
                            List<string> completed =
                                Console.ReadLine()
                                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                                .Select(c => c.Trim())
                                .ToList();

                            system.AddStudent(studentId, studentName, major, maxCredits, completed);
                            break;

                        case "3":
                            Console.Write("Student ID: ");
                            string sid = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string ccode = Console.ReadLine();

                            system.RegisterStudentForCourse(sid, ccode);
                            break;

                        case "4":
                            Console.Write("Student ID: ");
                            string dsid = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string dccode = Console.ReadLine();

                            system.DropStudentFromCourse(dsid, dccode);
                            break;

                        case "5":
                            system.DisplayAllCourses();
                            break;

                        case "6":
                            Console.Write("Student ID: ");
                            string ssid = Console.ReadLine();

                            system.DisplayStudentSchedule(ssid);
                            break;

                        case "7":
                            system.DisplaySystemSummary();
                            break;

                        case "8":
                            exit = true;
                            Console.WriteLine("Exiting system...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid numeric input. Please try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
