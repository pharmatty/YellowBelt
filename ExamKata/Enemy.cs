namespace ExamKata;

using System;

public class Enemy : IDamageable, ISpeakable
{
    public string Type { get; set; }
    public int Health { get; private set; }
    public int Damage { get; set; }

    public bool IsAlive => Health > 0;

    public Enemy(string type, int health, int damage)
    {
        Type = type;
        Health = health;
        Damage = damage;
    }

    public void Speak()
    {
        Console.WriteLine($"{Type} growls menacingly!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (IsAlive)
        {
            Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
        }
        else
        {
            Console.WriteLine($"{Type} takes {damage} damage and is defeated!");
        }
    }
}
