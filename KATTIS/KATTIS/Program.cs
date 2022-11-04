using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string stringInput;
        string[] stringList;

        stringInput = Console.ReadLine();
        stringList = stringInput.Split(' ');

        int matchesAmount = int.Parse(stringList[0]);
        int width = int.Parse(stringList[1]);
        int length = int.Parse(stringList[2]);
        double diagonal = Math.Sqrt(width * width + length * length);
        double match;
    
        for(int i = 0; i < matchesAmount; i++)
        {
            match = double.Parse(Console.ReadLine());
            if(match <= diagonal)
                Console.WriteLine("DA");
            else
                Console.WriteLine("NE");
        }
    }
}