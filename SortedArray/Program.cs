class Program
{
  public static T[] Sort<T>(T[] a, T[] b) where T:IComparable<T>
  {
    T[] arr=new T[a.Length+b.Length];
    int i=0;
    int j=0;
int idx=0;
    while(i<a.Length && j < b.Length)
    {
      if (a[i].CompareTo(b[j])<=0)
      {
        arr[idx++]=a[i];
        i++;
      }
      else
      {
        arr[idx++]=b[j];
        j++;
      }

     
      
    }
     while (i < a.Length)
      {
        arr[idx++]=a[i];
        i++;
      }

       while (j < b.Length)
      {
        arr[idx++]=b[j];
        j++;
      }

      return arr;
  
  }
  public static void Main()
  {
    Console.WriteLine("Enter the array1");
    string s1=Console.ReadLine();

    Console.WriteLine("ENter the array 2");

    string s2=Console.ReadLine();

    string[] str1=s1.Split(" ");
    int[] a1=new int[str1.Length];

    string[] str2=s2.Split(" ");

    int[] a2=new int[str2.Length];

    for (int i = 0; i < str1.Length; i++)
    {
      a1[i]=int.Parse(str1[i]);
      
    }

    for (int i = 0; i < str2.Length; i++)
    {
      a2[i]=int.Parse(str2[i]);
      
    }

   var res= Program.Sort<int>(a1,a2);

   foreach (var item in res)
   {
    Console.Write(item+" ");
    
   }
    
    
  }
}