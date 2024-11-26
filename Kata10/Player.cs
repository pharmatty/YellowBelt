using Kata10;

public class Player : IDamageable, ISpeakable
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public void Attack(IDamageable target, int damage)
    {
        Console.WriteLine($"{Name} attacks and deals {damage} damage.");
        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health > 0)
        {
            Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");
        }
        else
        {
            Console.WriteLine($"{Name} takes {damage} damage and is defeated!");
        }
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Prepare yourself!");
    }
}