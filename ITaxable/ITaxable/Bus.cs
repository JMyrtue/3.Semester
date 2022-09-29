// See https://aka.ms/new-console-template for more information

public class Bus : Vehicle, ITaxable
{

    protected int numberOfSeats;

    public Bus(int numberOfSeats, int regNumber, decimal value) :
        base(regNumber, 80, value)
    {
        this.numberOfSeats = numberOfSeats;
    }

    public int NumberOfSeats
    {
        get
        {
            return numberOfSeats;
        }
    }

    public void TaxValue()
    {
        Console.WriteLine($"Value: {value}; Tax: {value/2}");
    }
}
