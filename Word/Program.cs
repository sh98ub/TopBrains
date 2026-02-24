using System;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter the string");
    string st=Console.ReadLine();
    string[] arr=st.Split(' ',StringSplitOptions.RemoveEmptyEntries);

    Array.Reverse(arr);

   // Dictionary<char,int> word=new Dictionary<char, int>();

   foreach (var item in arr)
   {
    Console.Write(item+" ");
    
   }


    // foreach (var c in st.ToLower())
    // {
    //   if(c==' ')
    //   {
    //     continue;
    //   }
    //   if (word.ContainsKey(c))
    //   {
    //     word[c]++;
    //   }
    //   else
    //   {
    //     word[c]=1;
    //   }
    // }

    // foreach (var item in word)
    // {
    //   Console.WriteLine($"{item.Key}--{item.Value}");
      
    // }
  }
}