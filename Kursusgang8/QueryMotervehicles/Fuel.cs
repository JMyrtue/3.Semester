

class Fuel
{
    public string FuelName { get; }
    public static Fuel Octane95 => new Fuel("Octane95");
    public static Fuel Octane92 => new Fuel("Octane92");
    public static Fuel Diesel => new Fuel("Diesel");

    public Fuel(string fuelName)
    {
        FuelName = fuelName;
    }
}