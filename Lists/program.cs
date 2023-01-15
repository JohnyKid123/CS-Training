List<String> food = new List<String>();
food.Add("pizza");
food.Add("hotdog");
food.Add("ham");
food.Remove("ham");
food.Insert(0, "Sushi");
Console.WriteLine(food.Count);
food.Sort();
foreach (String item in food)
{
    Console.WriteLine(item);
}
