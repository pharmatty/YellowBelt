namespace Kata10;

public class Enemy : IDamageable, ISpeakable
{
    public string Type { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
        }
        else
        {
            Console.WriteLine($"{Type} takes {damage} damage and is defeated!");
        }
    }

    public void Speak()
    {
        Console.WriteLine($"{Type} starts shouting at you!");
    }
}
