namespace ExamKata;

using System;
using System.Collections.Generic;

public class Merchant : ISpeakable, ITradable
{
    public string Name { get; set; }
    public Dictionary<string, int> Inventory { get; set; }

    public Merchant(string name)
    {
        Name = name;
        Inventory = new Dictionary<string, int>
        {
            { "Potion", 20 },
            { "Shield", 50 },
            { "Fire Scroll", 40 }
        };
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Have a look at my offers for you!.");
    }

    public void DisplayInventory()
    {
        Console.WriteLine($"{Name}'s inventory:");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"{item.Key} - {item.Value} gold");
        }
    }

    public void Trade(Player player)
    {
        Console.WriteLine("What would you like to buy? (Enter item name or 'exit')");
        while (true)
        {
            string choice = Console.ReadLine();
            if (choice == "exit") break;

            if (Inventory.ContainsKey(choice))
            {
                int cost = Inventory[choice];
                if (player.Gold >= cost)
                {
                    player.Gold -= cost;
                    Console.WriteLine($"You purchased a {choice} for {cost} gold.");

                    if (choice == "Potion") player.Potions++;
                    if (choice == "Fire Scroll") player.FireScrolls++;

                    player.DisplayStatus();
                }
                else
                {
                    Console.WriteLine("You don't have enough gold!");
                }
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
            }
        }
    }
}
