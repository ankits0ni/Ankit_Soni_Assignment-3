using System;

// Truck class inheriting from Vehicle class
public class Truck : Vehicle
{
    // Additional properties specific to trucks
    public double Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Constructor
    public Truck(string model, string manufacturer, int year, double rentalPrice, double capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Override method to display truck details
    public override void DisplayDetails()
    {
        Console.WriteLine("Truck -");
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity} tons, Truck Type: {TruckType}, Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
    }
}
