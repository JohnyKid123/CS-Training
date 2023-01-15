Car car = new Car();
Bike bike = new Bike();
Boat boat = new Boat();
    Console.WriteLine(car.speed);
    Console.WriteLine(car.wheels);
Console.WriteLine(car.brand);
Console.WriteLine(car.year);
car.go();
    Console.WriteLine(bike.speed);
    Console.WriteLine(bike.wheels);
Console.WriteLine(bike.brand);
Console.WriteLine(bike.year);
bike.go();
    Console.WriteLine(boat.speed);
    Console.WriteLine(boat.wheels);
Console.WriteLine(boat.brand);
Console.WriteLine(boat.year);
boat.go();
class Vehicle
{
    public int speed = 60;
    public string country = "Bulgaria";
    public string owner = "Martin Ivanov";
    public void go()
    {
        Console.WriteLine($"This vehicle is owned by {owner} and it is moving with {speed} in {country}!");
    }
}
class Car : Vehicle
{
    public int wheels = 4;
    public string brand = "BMW";
    public int year = 2016;
}
class Bike : Vehicle
{
    public int wheels = 2;
    public string brand = "Drag";
    public int year = 2018;
}
class Boat : Vehicle
{
    public int  wheels = 0;
    public string brand = "brand";
    public int year = 2006;
}
