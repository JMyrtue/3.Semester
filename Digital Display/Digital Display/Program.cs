// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        DigitalDisplay dd = new DigitalDisplay();
        try
        {
            dd.SetDigit(3, 8);
            dd.SetDigit(0, 10);
            dd.GetDigit(0);
            dd.GetDigit(1);
            dd.GetDigit(2);
            dd.GetDigit(3);
            Console.ReadKey();


        }
        catch (NoSuchDigitException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class DigitalDisplay
{
    int[] display = { 1, 1, 1, 1 };

    public void GetDigit(int i)
    {
        if (i < 0 || i > 3)
            throw new NoSuchDigitException();
        Console.WriteLine(display[i]);
    }

    public void SetDigit(int i, int v)
    {
        if (i < 0 || i > 3)
            throw new NoSuchDigitException();
        if (v < 0 || v > 9)
            throw new NoSuchDigitException();
        display[i] = v;
    }
}

class NoSuchDigitException : Exception 
{
    public NoSuchDigitException()
    {

    }
    public NoSuchDigitException(string message) : base(message)
    {

    }
}

class IllegalDigitException : Exception
{
    public IllegalDigitException(string message) : base(message)
    {

    }

}