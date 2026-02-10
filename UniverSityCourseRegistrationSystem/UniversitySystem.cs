using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            if (AvailableCourses.ContainsKey(code))
                throw new ArgumentException("Course already exists");

            Course course = new Course(code, name, credits, maxCapacity, prerequisites);
            AvailableCourses.Add(code, course);
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            if (Students.ContainsKey(id))
                throw new ArgumentException("Student already exists");

            Student student = new Student(id, name, major, maxCredits, completedCourses);
            Students.Add(id, student);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId) || !AvailableCourses.ContainsKey(courseCode))
                return false;

            Student student = Students[studentId];
            Course course = AvailableCourses[courseCode];

            student.AddCourse(course);
            Console.WriteLine("Student registered successfully");
            return true;
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId))
                return false;

            Students[studentId].DropCourse(courseCode);
            return true;
        }

        public void DisplayAllCourses()
        {
            foreach (var c in AvailableCourses.Values)
            {
                Console.WriteLine(
                    $"{c.CourseCode} | {c.CourseName} | Credits: {c.Credits} | Enrollment: {c.GetEnrollmentInfo()}"
                );
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found");
                return;
            }

            Students[studentId].DisplaySchedule();
        }

        public void DisplaySystemSummary()
        {
            Console.WriteLine($"Total Students: {Students.Count}");
            Console.WriteLine($"Total Courses: {AvailableCourses.Count}");

            if (AvailableCourses.Count > 0)
            {
                double avgEnrollment =
                    AvailableCourses.Values
                        .Select(c => int.Parse(c.GetEnrollmentInfo().Split('/')[0]))
                        .Average();

                Console.WriteLine($"Average Enrollment: {avgEnrollment:F2}");
            }
        }
    }
}
