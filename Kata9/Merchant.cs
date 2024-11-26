public class Merchant
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public void Trade()
    {
        Console.WriteLine($"{Name}'s inventory: {string.Join(", ", Inventory)}");
    }
}