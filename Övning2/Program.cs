string[] toys = ["Fidgetspinner", "Ben 10 Watch", "Fushigi Ball", "Magic 8-Ball", "Sailor Moon Wand"];
string[] names = ["Zion", "Emin", "Alice", "Ludwig", "Leo"];
int[] numbers = [2, 3, 5, 6, 9];
List<string> cities = new List<string>();
string input = "";

for (int i = 0; i < toys.Length; i++)
{
    Console.WriteLine($"{names[i]} uses a {toys[i]} to punish humanity with {numbers[i]} years of pain!");
}

while (input != "exit")
{
    input = Console.ReadLine();
    // break;
    if (input != "exit")
    {
        cities.Add(input);
    }
    
}

for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine(cities[i]);
}

Console.ReadLine();