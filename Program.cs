using System;

namespace ParameterizedQuery
{
    class Program
    {
        static void Main()
        {
            Parameter obj = new Parameter();

            Console.Write("Enter Student Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            obj.AddNewStudent(id, name, marks);

            Console.ReadLine(); // Optional pause
        }
    }
}