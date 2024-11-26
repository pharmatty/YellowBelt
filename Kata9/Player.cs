using Kata9;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public void Attack(Enemy enemy, int damage)
    {
        Console.WriteLine($"{Name} attacks {enemy.Type} and deals {damage} damage.");
        enemy.TakeDamage(damage);
    }
}