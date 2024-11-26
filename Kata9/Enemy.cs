namespace Kata9;
public class Enemy
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
            Console.WriteLine($"{Type} takes {damage} damage and has fallen!");
        }
    }
}
