using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }
        public List<string> CompletedCourses { get; private set; }

        private List<Course> RegisteredCourses;

        public Student(string id, string name, string major, int maxCredits, List<string> completedCourses)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public bool AddCourse(Course course)
        {
            if (RegisteredCourses.Contains(course))
                throw new InvalidOperationException("Already registered");

            int currentCredits = RegisteredCourses.Sum(c => c.Credits);

            if (currentCredits + course.Credits > MaxCredits)
                throw new InvalidOperationException("Credit limit exceeded");

            if (!course.HasPrerequisites(CompletedCourses))
                throw new InvalidOperationException("Prerequisites not satisfied");

            if (course.IsFull())
                throw new InvalidOperationException("Course is full");

            RegisteredCourses.Add(course);
            course.EnrollStudent();
            return true;
        }

        public bool DropCourse(string courseCode)
        {
            Course course = RegisteredCourses
                .FirstOrDefault(c => c.CourseCode == courseCode);

            if (course == null)
                return false;

            RegisteredCourses.Remove(course);
            course.DropStudent();
            return true;
        }

        public void DisplaySchedule()
        {
            Console.WriteLine($"Schedule for {Name} ({StudentId}):");

            if (RegisteredCourses.Count == 0)
            {
                Console.WriteLine("No courses registered");
                return;
            }

            foreach (var c in RegisteredCourses)
            {
                Console.WriteLine($"{c.CourseCode} - {c.CourseName} ({c.Credits} credits)");
            }
        }
    }
}
