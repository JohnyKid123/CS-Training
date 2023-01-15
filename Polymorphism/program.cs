Car car = new Car();
Bike bike = new Bike();
Boat boat = new Boat();
Vehicle[] vehicles = { car, bike, boat };
foreach(Vehicle vehicle in vehicles)
{
    vehicle.go();
}
class Vehicle
{
    public virtual void go()
    {
        
    }
}
class Car : Vehicle
{
    public override void go()
    {
        Console.WriteLine("The car is moving");
    }
}
class Bike : Vehicle
{
    public override void go()
    {
        Console.WriteLine("The bike is moving");
    }
}
class Boat : Vehicle
{
    public override void go()
    {
        Console.WriteLine("The boat is moving");
    }
}
