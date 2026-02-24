using System;
class Program
{
  public static void Main()
  {
    string str1="baallOOn";
 //   str1=str1.ToLower();

    string str2="lnd";
    str2=str2.ToLower();

    string result="";

    for(int i = 0; i < str1.Length; i++)
    {
      char ch=str1[i];
      if(!(!"aeioutAEIOU".Contains(ch ) && str2.Contains(ch)))
      {
        result+=str1[i];
      }
    }
    Console.WriteLine(result);
    string final=string.Empty;


    for(int i = 1; i < result.Length; i++)
    {
      if (result[i] != result[i-1])
      {
        final+=result[i-1];
        
      }
     
      
    }
     final+=result[result.Length-1];
    Console.WriteLine(final);
    

  }
}
