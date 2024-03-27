using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different types of vehicles
        Car car1 = new Car("Supra", "Toyota", 2020, 50, 5, "Petrol", "Automatic", false);
        Truck truck1 = new Truck("Escalade EXT", "Cadillac", 2021, 100, 2.5, "Pickup", true);
        Motorcycle motorcycle1 = new Motorcycle("Heritage Classic", "Harley-Davidson", 2019, 30, 1000, "Petrol", true);

        // Creating a rental agency
        RentalAgency agency = new RentalAgency(10);

        // Adding vehicles to the rental agency's fleet
        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(motorcycle1);

        // Renting a vehicle
        agency.RentVehicle(car1, 3);
        agency.RentVehicle(truck1, 5);
        agency.RentVehicle(motorcycle1, 2);

        // Displaying details of vehicles in the fleet
        Console.WriteLine("Details of vehicles in the fleet:");
        foreach (Vehicle vehicle in agency.GetFleet())
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }

        // Displaying total revenue
        Console.WriteLine($"Total revenue: ${agency.TotalRevenue}");
    }
}
