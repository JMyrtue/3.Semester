// See https://aka.ms/new-console-template for more information

public class House : FixedProperty, ITaxable
{

    protected double area;

    public House(string location, bool inCity, double area,
                 decimal value) :
        base(location, inCity, value)
    {
        this.area = area;
    }

    public double Area
    {
        get
        {
            return area;
        }
    }

    public void TaxValue()
    {
        Console.WriteLine($"Value: {estimatedValue}; Tax: {estimatedValue / 2}");
    }
}