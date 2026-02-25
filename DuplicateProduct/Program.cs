using System;
class Program
{
  public static void Main()
  {
            var input = new List<string> { "Pen", "Book", "Pen", "Pencil", "Book" };

            var res=input.GroupBy(x=>x).Where(g=>g.Count()>1).Select(g=>g.Key).ToList();

            foreach (var item in res)
            {
              Console.WriteLine(item);
              
            }

  }
  
}