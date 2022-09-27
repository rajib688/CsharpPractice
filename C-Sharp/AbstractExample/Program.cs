// See https://aka.ms/new-console-template for more information

using AbstractExample;

var type = Console.ReadLine();


Vehicle Vehicle = GetVehicle(type);
Vehicle.Color = "Red";
Vehicle.Weight = 200;
Vehicle.Start();
Vehicle.Wash();

Vehicle GetVehicle(string type)
{
	if (type=="Car")
	{
		return new Car();
	}
	else
	{
		return new Plane();
	}
}