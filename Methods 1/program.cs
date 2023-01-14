static double num(double first,double second)
{
    return first * second;
}
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double result = num(x, y); 
Console.WriteLine(result);
