namespace Kata10;

using System.Collections.Generic;

public class Merchant : ISpeakable
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Would you like to trade?");
    }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s inventory: {string.Join(", ", Inventory)}");
    }
}
