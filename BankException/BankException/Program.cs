// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        try
        {
            BankAccount mor = new BankAccount(10000.0);
            mor.Deposit(500.0);
            Console.WriteLine(mor.Balance);
            mor.Withdraw(11000.0);
        }
        catch (InsufficientFundsException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class BankAccount
{
    public double Balance { get; set; }

    public BankAccount(double balance)
    {
        if (balance < 0)
            throw new InsufficientFundsException("Du kan ikke oprette en konto, når du skylder!");
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (Balance - amount < 0)
            throw new InsufficientFundsException("Så mange penge har du ikke!");
        Balance -= amount;
    }
}


class InsufficientFundsException : Exception
{
    public InsufficientFundsException()
    {
    }

    public InsufficientFundsException(string message) : base(message)
    {
    }


}