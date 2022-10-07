// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        Car car = new Car();
        try
        {
            car.PressClutch();
            car.TurnOnIgnition();
            car.ReleaseHandBrake();
            car.ReleaseClutch();
            Console.WriteLine("Car is running!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class Car
{
    bool clutch = false;
    bool ignition = false;
    bool handBrake = true;
    public void PressClutch()
    {
        if (clutch == true)
            throw new ClutchException("You're already pressing the clutch");
        clutch = true;
    }

    public void ReleaseClutch()
    {
        if (clutch == false)
            throw new ClutchException("The clutch wasn't pressed down");
        if (ignition == false)
            throw new IgnitionException("Ignition was not on, when trying to release clutch");
        if (handBrake == true)
            throw new HandBrakeException("Handbrake was pulled, when trying to release clutch");
        clutch = false;
    }

    public void TurnOnIgnition()
    {
        if (ignition == true)
            throw new IgnitionException("Ignition was already on");
        if (clutch == false)
            throw new ClutchException("Can't turn on ignition before pressing the cluth");
        ignition = true;
    }

    public void PullHandBrake()
    {
        if (handBrake == true)
            throw new HandBrakeException("Handbrake already pulled");
        handBrake = true;
    }

    public void ReleaseHandBrake()
    {
        if (handBrake == false)
            throw new HandBrakeException("Handbrake already released");
        if (clutch == false)
            throw new ClutchException("Clutch not pressed before release handbrake");
        if (ignition == false)
            throw new IgnitionException("Ignition not turned on, before pulling handbrake");
        handBrake = false;
    }
}

class ClutchException : Exception
{
    public ClutchException(string message) : base(message)
    {

    }

}

class IgnitionException : Exception
{
    public IgnitionException(string message) : base(message)
    {

    }

}

class HandBrakeException : Exception
{
    public HandBrakeException(string message) : base(message)
    {

    }

}