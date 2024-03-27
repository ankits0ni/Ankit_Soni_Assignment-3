using System;

// RentalAgency class to manage the rental agency's fleet of vehicles
public class RentalAgency
{
    private Vehicle[] Fleet;
    private int fleetSize;
    public double TotalRevenue { get; private set; }

    public RentalAgency(int size)
    {
        Fleet = new Vehicle[size];
        fleetSize = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        if (fleetSize < Fleet.Length)
        {
            Fleet[fleetSize] = vehicle;
            fleetSize++;
        }
        else
        {
            Console.WriteLine("Fleet is full. Cannot add more vehicles.");
        }
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        int index = Array.IndexOf(Fleet, vehicle);
        if (index != -1)
        {
            for (int i = index; i < fleetSize - 1; i++)
            {
                Fleet[i] = Fleet[i + 1];
            }
            fleetSize--;
            Fleet[fleetSize] = null;
        }
        else
        {
            Console.WriteLine("Vehicle not found in the fleet.");
        }
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        double rentalCost = vehicle.RentalPrice * days;
        TotalRevenue += rentalCost;
        Console.WriteLine($"Vehicle rented: {vehicle.Model} for {days} days. Rental cost: ${rentalCost}");
    }

    // Public method to access the fleet
    public Vehicle[] GetFleet()
    {
        return Fleet;
    }
}
