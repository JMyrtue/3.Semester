abstract class MoterVehicle
{
    protected Fuel _fuel;   

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    public virtual Fuel Fuel
    {
        get { return _fuel; }
        set { _fuel = value; }
    }
}
