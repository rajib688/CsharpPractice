// See https://aka.ms/new-console-template for more information
using AbstractExample;

Console.Write("Enter your Input: ");

var Type = Console.ReadLine();
//Vehicle vehicleCar = new Car();
Vehicle vehicleCar = GetVehicle(Type);
//Vehicle vehiclePlane = new Plane();
vehicleCar.Color = "Red";
vehicleCar.Start();
vehicleCar.Wash();
//vehiclePlane.Start();


Vehicle GetVehicle(string Type)
{
    if (Type == "Car")
        return new Car();
    else
        return new Plane();
}