public class NPC
{
    public string Name { get; set; }
    public string Dialogue { get; set; }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: {Dialogue}");
    }
}