namespace Kata10;

public class NPC : ISpeakable
{
    public string Name { get; set; }
    public string Dialogue { get; set; }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: {Dialogue}");
    }
}
