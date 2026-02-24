using System;
class Program
{
  public static void Main()
  {
    Program p=new Program();
    Console.WriteLine("Enter the radius");

    double radius=double.Parse(Console.ReadLine());

    double ans=p.calculateArea(radius);

    Console.WriteLine($"{ans:F3}");
    

  }

  public double calculateArea(double r)
  {
    return 2*3.1456*r*r;
  }

}