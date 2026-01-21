using System;
class Program
{
  public static void Main()
  {
    Dictionary<int,int> employeedetails=new Dictionary<int, int>()
    {
      {101,1000},
      {102,2000},
      {103,3000},
      {104,4000},
      {105,5000},
      {106,6000}
      
    };

    List<int> list=new List<int>()
    {
      101,102,103
    };
    int sum=0;

    foreach (var item in list)
    {
      if (employeedetails.ContainsKey(item))
      {
        sum+=employeedetails[item];
      }
      
    }
    Console.WriteLine(sum);
  }
}