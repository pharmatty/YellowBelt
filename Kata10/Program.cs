namespace Kata10;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Class instance
        Player player = new Player { Name = "Mathias", Health = 150, Level = 1 };
        Enemy enemy = new Enemy { Type = "Goblin", Health = 50, Damage = 10 };
        NPC npc = new NPC { Name = "Villager", Dialogue = "Welcome to our village!" };
        Merchant merchant = new Merchant
        {
            Name = "Trader",
            Inventory = new List<string> { "Sword", "Shield", "Potion" }
        };

        // Polymorphism
        
        List<ISpeakable> speakables = new List<ISpeakable> { player, enemy, npc, merchant };
        foreach (ISpeakable speakable in speakables)
        {
            speakable.Speak();
        }

        // Call TakeDamage <-> IDamageable
        List<IDamageable> damageables = new List<IDamageable> { player, enemy };
        foreach (IDamageable damageable in damageables)
        {
            damageable.TakeDamage(20);
        }
    }
}
