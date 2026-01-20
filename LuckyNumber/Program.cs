using System;

public class Program
{

  public  int dgitSum(int num)
  {
    int sum=0;
    while (num > 0)
    {
      sum+=num%10;
      num=num/10;
    }

    return sum*sum;

  }
  public static void Main()
  {
    Program p=new Program();
    int count=0;
    for(int i = 20; i <= 30; i++)
    {
      int val=p.dgitSum(i);

      int val2=p.Squaresum( i);

      if (val == val2)
      {
        count++;
      }
    }
    Console.WriteLine(count);
    
  }
  public int Squaresum(int num)
  {
    int val=num*num;
    int sum=0;

    while (val > 0)
    {
      sum+=val%10;
      val=val/10;
    }

    return sum;

    
  }
}