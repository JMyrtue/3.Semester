// See https://aka.ms/new-console-template for more information


using System.Reflection.PortableExecutable;

namespace RadionPi;

class Program
{
    static void Main()
    {
        //udregninger calc = new udregninger();
        //System.Console.WriteLine(calc.RadianToPi(180));
        //Console.WriteLine(calc.PiToRadian(2));

        //PrintStars StarPrinter = new PrintStars();
        //{
        //    StarPrinter.ReversePrint(10);
        //}

        //Console.WriteLine("Enter a number:");
        //string input = Console.ReadLine();
        //int tal = int.Parse(input);
        //Console.WriteLine("Squareroot is: " + Math.Sqrt(tal));

        //Console.WriteLine("How many members are in your group?:");
        //string input = Console.ReadLine();
        //int groupSize = int.Parse(input);

        List<string> groupMembers = new List<string>();
        string input = " ";
        while(input != "")
        {
            Console.Write("Type name of group member: ");
            input = Console.ReadLine();
            groupMembers.Add(input);
        }

        foreach(string member in groupMembers)
        {
            Console.WriteLine(member);
        }
    }

}
public class udregninger {
    public double RadianToPi(int degrees)
    {
        return degrees * (Math.PI / 180);
    }

    public double PiToRadian(int radians)
    {
        return radians * (180 / Math.PI);
    }

}

public class PrintStars
{
    public void StarPrint(int MaxStar)
    {
        string stars = "";
        for (int i = 0; i < MaxStar; i++)
        {
            stars += "*";
            Console.WriteLine(stars);
        }
    }
    public void ReversePrint(int Maxstar)
    {
        List<char> stars = new List<char>();

        for (int i = 0; i < Maxstar; i++)
        {
            stars.Add('*');    
        }

        for(int i = Maxstar; i > 0; i--)
        {
            foreach (char c in stars)
            {
                Console.Write(c);
            }
            Console.WriteLine(" ");
            stars.Remove('*');
        }
    }
}





