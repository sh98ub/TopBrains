class Result<T>
{
private T data;
private string status;
public Result(T data, string status){
  this.data=data;
  this.status=status;
    
  }

  public T GetData()
  {
    return data;
  }

  public string DisplayResullt()
  {
    return $" value is {data} and status is {status}";
  }


}
class Calculator
{
  public static T Add<T>(T a, T b)
  {

    dynamic x=a;
    dynamic y=b;
    return x+y;
  }
}

class Progran
{
  public static void Main()
  {
    
    Result<int> result=new Result<int>(65,"Evaluated");

    int sum=Calculator.Add<int>(20,30);

    Console.WriteLine(sum);

  }
}