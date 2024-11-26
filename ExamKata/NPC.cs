namespace ExamKata;

using System;

public class NPC : ISpeakable
{
    private string[] dialogues;

    public string Name { get; set; }

    public NPC(string name, string[] dialogues)
    {
        Name = name;
        this.dialogues = dialogues;
    }

    public void Speak()
    {
        Random random = new Random();
        string dialogue = dialogues[random.Next(dialogues.Length)];
        Console.WriteLine($"{Name} says: {dialogue}");
    }
}
