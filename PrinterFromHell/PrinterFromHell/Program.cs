// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        PrinterFromHell printer = new PrinterFromHell();
        while (true) 
        {
            try
            {
                printer.Print();
            }
            catch (OutOfPaperException e)
            {
                bool b = true;
                while (b)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("/changePaper to continue!");
                    if (Console.ReadLine() == "/changePaper")
                        b = false;
                }
            }
            catch(OutOfTonerException e)
            {
                bool b = true;
                while (b)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("/changeInk to continue!");
                    if (Console.ReadLine() == "/changeInk")
                        b = false;
                }
            }
            catch(PaperJamException e)
            {
                bool b = true;
                while (b)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("/removePaper to continue!");
                    if (Console.ReadLine() == "/removePaper")
                        b = false;
                }
            }
        }
    }
}

class PrinterFromHell
{
    Random random = new Random();

    public void Print()
    {
        int exePick = random.Next(1, 4);

        switch (exePick)
        {
            case 1:
                throw new OutOfPaperException("Fill paper in tray!");
            case 2:
                throw new OutOfTonerException("Fill ink!");
            case 3:
                throw new PaperJamException("Paper stuck in machine - remove it!");
        }
    }
}

class OutOfPaperException : Exception
{
    public OutOfPaperException(string message) : base(message)
    {

    }
}

class OutOfTonerException : Exception
{
    public OutOfTonerException(string message) : base(message)
    {

    }

}

class PaperJamException : Exception
{
    public PaperJamException(string message) : base(message)
    {

    }
}