namespace ExamKata;
public class Game
{
    private Player player;

    public void Start()
    {
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        player = new Player(playerName, 100, 1, 0, 50);
        player.Speak();

        Random random = new Random();
        while (player.IsAlive)
        {
            Console.WriteLine("\nA new encounter begins!");
            int encounterType = random.Next(3); // 0 = Enemy, 1 = NPC, 2 = Merchant

            if (encounterType == 0)
            {
                Enemy enemy = new Enemy("Goblin", random.Next(20, 50), random.Next(5, 15));
                Console.WriteLine($"A wild {enemy.Type} appears with {enemy.Health} health and {enemy.Damage} damage!");
                Combat(enemy);
            }
            else if (encounterType == 1)
            {
                NPC npc = GenerateRandomNPC();
                Console.WriteLine($"You encounter {npc.Name}.");
                Console.WriteLine("Do you want to speak to them? (yes/no)");
                string choice = Console.ReadLine().ToLower();

                if (choice == "yes")
                {
                    npc.Speak();
                }
                else
                {
                    Console.WriteLine($"You decide to ignore {npc.Name} and move on.");
                }
            }
            else if (encounterType == 2)
            {
                Merchant merchant = new Merchant("Trader");
                merchant.Speak();
                merchant.DisplayInventory();
                merchant.Trade(player);
            }

            player.DisplayStatus();

            if (!player.IsAlive)
            {
                Console.WriteLine("Game Over! You have been defeated.");
                break;
            }
        }
    }

    private void Combat(Enemy enemy)
    {
        while (enemy.IsAlive && player.IsAlive)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.WriteLine("3. Use Potion");
            Console.WriteLine("4. Use Fire Scroll");
            Console.Write("> ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                player.Attack(enemy, 20);
            }
            else if (choice == "2")
            {
                player.Heal();
            }
            else if (choice == "3")
            {
                player.UsePotion();
            }
            else if (choice == "4")
            {
                player.UseFireScroll(enemy);
            }

            if (enemy.IsAlive)
            {
                Console.WriteLine($"The {enemy.Type} attacks for {enemy.Damage} damage!");
                player.TakeDamage(enemy.Damage);
            }
        }

        if (!enemy.IsAlive)
        {
            player.GainExperience(30);
            player.EarnGold(20);
        }
    }

    private NPC GenerateRandomNPC()
    {
        Random random = new Random();
        int npcType = random.Next(3);

        if (npcType == 0) return new NPC("Princess", new[] { "Do not trust the sorceress friend! She is a foul being!" });
        if (npcType == 1) return new NPC("Thief", new[] { "Watch your pockets young one, you never know if you might lose something." });
        return new NPC("Sorceress", new[] { "The fire scroll is a powerful tool to aid you in your quest. May the stars guide you!" });
    }
}
