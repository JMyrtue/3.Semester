using System;

//Opg 1 

//Exceptions is a feature in programmering languages, where you indicate an unintende behavior of the program. The terminology, is that you throw
//an exception, and catch it, in order to handle said behavior. Exceptions are used to avoid crashing your program when something unintended happens. Finally, 
//exceptions are a key koncept of testing - atleast with the xUnit framework.

//Code coverage is principle of deciding how much of your program is covered by test cases. There are no standard as to what percentage of code coverage is needed 
//for a program of quality, and achieving 100% code coverage can be expensive in man hours.

//TDD is the concept of creating a test case for the functionality you want to develop, before you develop said funcitonality. If used correctly, you will end up 
//creating more and more testcases as the development progresses. The benefits of the strategy, is that your program will be simpler, more efficient and more readable, 
//than if test cases was written after development.

//Opg 2

class Program
{
    static void Main()
    {
        String s = new String("HEJSA");
        String d = new String("HEJSA");


        Console.WriteLine(s.CharAt(3));
        Console.WriteLine(s.Length());
        Console.WriteLine(s.SubString(2,2));
        s.ToLowerCase();
        Console.WriteLine(s);
        Console.WriteLine(s.Equals(d));
        String b = new String("hejsa");
        Console.WriteLine(s.Equals(b));

    }
}

class String
{
    char[] Sting;

    public String(string input)
    {
        Sting = new char[input.Length];
        Sting = input.ToCharArray();
    }

    public char CharAt(int index)
    {
        return Sting[index];
    } 

    public int Length()
    {
        return Sting.Length;
    }

    public char[] SubString(int startIndex, int subStringLength)
    {
        try
        {
            if (Sting[startIndex + subStringLength] == null)
                throw new ArgumentNullException();

            char[] result = new char[subStringLength];
            for(int i = startIndex, j = 0; i <= subStringLength; i++, j++)
            {
                result[j] = Sting[i];
            }

            return result;
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Requested substring is too long.");

            char[] empty = new char[0];
            return empty;
        }
    }

    public void ToLowerCase()
    {
        for(int i = 0; i < Sting.Length; i++)
        {
            Sting[i] = char.ToLower(Sting[i]);
        }
    }

    public bool Equals(char[] otherSting)
    {
        if(Sting == otherSting)
            return true;
        return false;
    }
    
}