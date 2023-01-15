Dog dog = new Dog();
Cat cat = new Cat();
dog.Speak();
cat.Speak();
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("This animal can speak now!");
    }
   
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("This animal can speak now! He says he is a dog.");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("This animal can speak now! He says he is a cat.");
    }
}
