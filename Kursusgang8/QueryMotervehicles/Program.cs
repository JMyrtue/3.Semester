using System.Security.Cryptography.X509Certificates;
using System.Linq;
class Program
{
    static void Main()
    {
        List<MoterVehicle> vehicles = new List<MoterVehicle>()
    {
        new Car() { Make = "Opel", Model = "Zafira", Year = 2002, Fuel = Fuel.Octane95, Price = 112000 },
        new Car() { Make = "Ford", Model = "Fiesta", Year = 1994, Fuel = Fuel.Octane92, HasSunRoof = true, Price = 72000 },
        new Car() { Make = "Mazda", Model = "6", Year = 2007, Fuel = Fuel.Octane95, Price = 200000 },
        new Car() { Make = "Opel", Model = "Astra", Year = 1995, Fuel = Fuel.Octane92, HasSunRoof = true, Price = 45000 },
        new Car() { Make = "Opel", Model = "Astra", Year = 1997, Fuel = Fuel.Diesel, Price = 52000 },
        new Car() { Make = "Opel", Model = "Zafira", Year = 2001, Fuel = Fuel.Diesel, Price = 137000 },
        new Car() { Make = "Ford", Model = "Focus", Year = 2007, Fuel = Fuel.Octane92, HasSunRoof = true, Price = 199999 },
        new Car() { Make = "Opel", Model = "Astra", Year = 1996, Fuel = Fuel.Diesel, Price = 29000 },
        new Bus() { Make = "Scania", Model = "Buzz", Year = 1999, Price = 275000, NumSeats = 52 },
        new Bus() { Make = "Scania", Model = "Fuzz", Year = 2000, Price = 225000, NumSeats = 12 }
    };

        //Opg1
        decimal averagePrice = (vehicles.Select(v => v.Price).Sum()) / vehicles.Count;
        decimal otherAveragePrice = vehicles.Average(v => v.Price);

        Console.WriteLine("Average price of all vehicles: ");
        Console.WriteLine(averagePrice);
        Console.WriteLine(otherAveragePrice);
        Console.WriteLine();

        //Opg2
        int averageBusSeats = vehicles.OfType<Bus>().Select(b => b.NumSeats).Sum() / vehicles.OfType<Bus>().Count();
        Console.WriteLine("Average amount of seats in busses: ");
        Console.WriteLine(averageBusSeats);
        Console.WriteLine();

        //Opg3
        int carsWithSunroof = vehicles.OfType<Car>().Where(v => v.HasSunRoof == true).Count();
        Console.WriteLine("Number of cars with sunroof: ");
        Console.WriteLine(carsWithSunroof);
        Console.WriteLine();

        //Opg4
        var groupedVehicles = vehicles.GroupBy(v => v.Make);
        Console.WriteLine("Vehicles grouped by Make: ");
        Console.WriteLine();
        foreach(var makeGroup in groupedVehicles)
        {
            Console.WriteLine($"Make: {makeGroup.Key}");

            foreach(var vehicle in makeGroup)
            {
                Console.WriteLine($"{vehicle.Model} {vehicle.Year}");
            }
            Console.WriteLine();
        }

        //Opg5
        decimal minPrice = 50000;
        decimal maxPrice = 200000;
        var octane92Cars = vehicles.OfType<Car>().Where(v => (v.Fuel.FuelName == "Octane92" || v.Fuel.FuelName == "Octane95") && v.Price > minPrice && v.Price < maxPrice)  
                                   .OrderBy(v => v.Make)       
                                   .ThenBy(v => v.Model)
                                   .ThenBy(v => v.Price);

        Console.WriteLine("Octane specific cars: "); 
        foreach(var vehicle in octane92Cars)
        {
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Price}");
        }
        Console.WriteLine();

        //Opg6
        int currentYear = DateTime.Now.Year;
        var veteranVehicles = vehicles.Where(v => (currentYear - v.Year) > 25).Select(v => new { Model_Make = v.Make + " " + v.Model, YearsOld = currentYear - v.Year });

        Console.WriteLine("Veteran Vehicles: ");
        foreach(var vehicle in veteranVehicles)
        {
            Console.WriteLine($"{vehicle.Model_Make} {vehicle.YearsOld}" );
        }
    }

}