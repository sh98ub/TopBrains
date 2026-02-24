// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Text;

class Program
{
  public static void Main()
  {
    string str="hi my name is shubham ";
    str=str.Trim();

    string[] str1=str.Split(" ");

  for(int i = 0; i < str1.Length; i++)
    {
      if (str1[i].Length > 0)
      {
        str1[i]=char.ToUpper(str1[i][0])+str1[i].Substring(1);
      }
    }
   
      String result=string.Join(" ",str1);
    
    Console.WriteLine(result);
  }
}