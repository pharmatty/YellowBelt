public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public void Attack(IAttackable target, int damage)
    {
        Console.WriteLine($"Player {Name} attacks and deals {damage} damage.");
        target.TakeDamage(damage);
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"Player {Name} gains {exp} experience points. Total Experience: {Experience}");
    }
}