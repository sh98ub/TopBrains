// class Program
// {
//   public static void Main()
//   {
//     Console.WriteLine("Enter the string");
//     string st=Console.ReadLine();
// string[] arr=st.ToLower().Split(" ",StringSplitOptions.RemoveEmptyEntries);
// //String result="";

// arr[0]=char.ToUpper(arr[0]);

// for (int i = 1; i < arr.Length; i++)
// {
//   if(arr[i-1]==' ')
//       {
//         arr[i]=char.ToUpper(arr[i]);
//       }

      
// }
// Console.WriteLine(new String(arr));

    
//    }
//   }


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "programming";

       

        // TODO:
        // 1. Remove duplicates using HashSet
        // 2. Preserve order
        // 3. Reverse final string

        Console.WriteLine(ProcessString(input));
    }

    static string ProcessString(string input)
    {

       HashSet<char> set=new HashSet<char>();

        string res="";

        foreach (var item in input)
        {
      if (!set.Contains(item))
      {
        set.Add(item);
        res+=item;
      }
          
        }
        // YOUR CODE HERE
        return res;
    }
}
