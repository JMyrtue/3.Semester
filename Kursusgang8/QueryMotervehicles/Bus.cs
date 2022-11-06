class Bus : MoterVehicle
{
    public Bus()
    {
        _fuel = Fuel.Diesel;
    }
    public int NumSeats { get; set; }

    public override Fuel Fuel
    {
        set { }
    }
}
