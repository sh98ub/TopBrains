public class Account
{
  public string AccountNumber { get; set; }

  public decimal Balance { get; set; }

  public decimal Deposit(decimal amount)
  {
    if (amount < 0)
    {
      throw new ArgumentException("Deposit Amount must be positive");

    }

    Balance+=amount;

    return Balance;
  }

  public decimal Withdraw(decimal amount)
  {
    if (amount <= 0)
    {
      throw new ArgumentException("Withdraw amount must be positvie");
    }

    if (amount > Balance)
    {
      throw new InvalidOperationException("Insufficient funds");
    }
    Balance-=amount;

    return Balance;
  }
}

class Program
{
  public static void Main()
  {
    Console.WriteLine(@"1.Deposit
    2.WithDraw
    choose option");

    int choic=int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Account Number");
    string accountNumber=Console.ReadLine();

    Console.WriteLine("Enter the initial Balance");
    decimal balance=decimal.Parse(Console.ReadLine());
    Account account=new Account();
    account.AccountNumber=accountNumber;
    account.Balance=balance;

    try
    {
      if (choic == 1)
      {
        Console.WriteLine("Enter the amount to deposit");

        decimal dep=decimal.Parse(Console.ReadLine());
      Console.WriteLine( account.Deposit(dep));
        
      }else if (choic == 2)
      {
        Console.WriteLine("ENter the amount to wihdraw");
        decimal with=decimal.Parse(Console.ReadLine());
        Console.WriteLine(account.Withdraw(with));
      }
    }catch( ArgumentException e)
    {
      Console.WriteLine(e.Message);
    }catch(InvalidOperationException e)
    {
      Console.WriteLine(e.Message);
    }
  }
}