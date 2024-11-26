namespace ExamKata;

using System;

public class Player : IDamageable, ISpeakable
{
    public string Name { get; set; }
    public int Health { get; private set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int Gold { get; set; }
    public int Potions { get; set; }
    public int FireScrolls { get; set; }

    public bool IsAlive => Health > 0;

    public Player(string name, int health, int level, int experience, int gold)
    {
        Name = name;
        Health = health;
        Level = level;
        Experience = experience;
        Gold = gold;
        Potions = 0;
        FireScrolls = 0;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: I'm ready for my journey!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Health left: {Health}");
    }

    public void Attack(IDamageable target, int damage)
    {
        Console.WriteLine($"{Name} attacks and deals {damage} damage.");
        target.TakeDamage(damage);
    }
    
    public void UsePotion()
    {
        if (Potions > 0)
        {
            Potions--;
            int healAmount = 50;
            Health += healAmount;
            Console.WriteLine($"{Name} uses a potion and heals for {healAmount} health. Current health: {Health}");
        }
        else
        {
            Console.WriteLine("You have no potions!");
        }
    }

    public void UseFireScroll(IDamageable target)
    {
        if (FireScrolls > 0)
        {
            FireScrolls--;
            int fireDamage = 40;
            Console.WriteLine($"{Name} uses a fire scroll to deal {fireDamage} damage!");
            target.TakeDamage(fireDamage);
        }
        else
        {
            Console.WriteLine("You have no fire scrolls!");
        }
    }

    public void Heal()
    {
        int healAmount = 20;
        Health += healAmount;
        Console.WriteLine($"{Name} heals for {healAmount} health. Current health: {Health}");
    }

    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"{Name} gains {exp} experience points.");
        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    public void EarnGold(int amount)
    {
        Gold += amount;
        Console.WriteLine($"{Name} earns {amount} gold. Current gold: {Gold}");
    }

    private void LevelUp()
    {
        Level++;
        Experience = 0;
        Console.WriteLine($"Congratulations! {Name} leveled up to Level {Level}!");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Player Status - Health: {Health}, Level: {Level}, Experience: {Experience}, Gold: {Gold}, Potions: {Potions}, Fire Scrolls: {FireScrolls}");
    }
}
