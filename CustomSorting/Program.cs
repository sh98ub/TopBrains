// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System.Security.Cryptography;

public class Student
{
  public string Name { get; set; }
  public int Age { get; set; }

  public double Marks { get; set; }

  
}

class Program
{

  public static void Main()
  {
      List<Student> students=new List<Student>()
    {
     new Student {Name="Shubham",Age=20,Marks=40},
      new Student{Name="Rohit",Age=23,Marks=45},
     new Student {Name="Harsh",Age=22,Marks=42},
     new Student {Name="Ravi",Age=21,Marks=42},
     new Student {Name="Raj",Age=23,Marks=40}
    };
    

    var num=students.OrderBy(n=>n.Marks).ThenBy(n=>n.Age).ToList();


    foreach (Student item in num)
    {
      Console.WriteLine($"Name {item.Name} age id {item.Age} and marks is {item.Marks}");
      
    }
  }
}
