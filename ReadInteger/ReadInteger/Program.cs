// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        bool running = true;
        do
        {
            try
            {
                Console.WriteLine(ReadInteger());
                running = false;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        } while (running);
    }   

    static int ReadInteger()
    {
        int input;
            Console.WriteLine("Give an integer input:");
            input = int.Parse(Console.ReadLine());
            return input;
    }
}

