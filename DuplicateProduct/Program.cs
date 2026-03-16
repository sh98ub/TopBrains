<<<<<<< HEAD
﻿using System;
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
  
=======
﻿using System;
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
  
>>>>>>> 202ba7eeef2c0ff5757aaf71e6aedf8412f4c7cd
}