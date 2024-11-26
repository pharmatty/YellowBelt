namespace Kata9;

class Program
{
    static void Main(string[] args)
    {
        // Player inst.
        Player player = new Player { Name = "Mathias", Health = 100, Level = 1 };

        // Enemy inst.
        Enemy enemy = new Enemy { Type = "Goblin", Health = 50, Damage = 10 };

        // NPC inst.
        NPC npc = new NPC { Name = "Townsfolk", Dialogue = "Welcome to our village!" };

        // Merchant inst.
        Merchant merchant = new Merchant
        {
            Name = "Trader",
            Inventory = new List<string> { "Sword", "Shield", "Potion" }
        };

        
        Console.WriteLine("Combat Engagement:");
        player.Attack(enemy, 20); 

        Console.WriteLine("\nNPC:");
        npc.Speak(); 

        Console.WriteLine("\nMerchant:");
        merchant.Trade(); 
    }
}
