using System.Web;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter the value and operation you want to perform");

    string op=Console.ReadLine();

    string[] str=op.Split(" ");

    if (str.Length != 3)
    {
      Console.WriteLine("Error:InvalidExpression");
    }

   
  
int a =0;
int b=0;
    if((int.TryParse(str[0],out a)) && (int.TryParse(str[2],out  b)))
    {
      if(str[1]=="+" ||str[1]=="-"|| str[1]=="*"||str[1]=="/")
      {
        
        if (str[1] == "+")
        {
          Console.WriteLine( a+b);
        }else if (str[1] == "-")
        {
          Console.WriteLine(a-b);
        }else if (str[1] == "*")
        {
          Console.WriteLine(a*b);
        }else if (str[1] == "/")
        {
          if (b == 0)
          {
            Console.WriteLine("Error divide by zero");
          }
          else
          {
            Console.WriteLine(a/b);
          }
        }
      }
      else
      {
        Console.WriteLine("Error: Unknown Operator");
      }
    }
    else
    {
      Console.WriteLine("Error Invalid Number");
    }

    
  }
}