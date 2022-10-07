// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        GearBox GB = new GearBox();
        try
        {
            while (true)
            {
                Console.WriteLine("Current gear: " + GB.gear);
                Console.WriteLine("Enter new gear:");
                GB.ChangeGear(int.Parse(Console.ReadLine()));
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("The car has died.");
        }
        catch(IllegalGearChangeException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("The car has died.");
        }
    }
}

class GearBox
{
    public int gear = 1;

    public void ChangeGear(int newGear)
    {
        if (newGear != -1 && newGear != 1 && newGear != 2 && newGear != 3 && newGear != 4 && newGear != 5)
            throw new ArgumentException("Not a valid gear");
        if (newGear == -1 && gear != 1)
            throw new IllegalGearChangeException("Can only go into reverse from first gear!");
        if ((newGear == -1 && gear == 1) || (newGear == 1 && gear == -1))
            gear = newGear;
        else if (newGear != gear + 1 && newGear != gear - 1)
            throw new IllegalGearChangeException("Cannot jump more then one gear!");
        gear = newGear;
    }
}

class IllegalGearChangeException : Exception
{
    public IllegalGearChangeException(string message) : base(message)
    {

    }
}