static void sign(string firstName,string lastName,int age,string town)
{
    Console.WriteLine($"Hello {firstName} {lastName}. Your are {age} years old and you are from {town}.");
}
string firstName = "Alex";
string lastName = "Venkov";
int age = 15;
string town = "Shumen";
sign(firstName,lastName,age,town);
