namespace MiniKata7
{
    // Player class properties
    class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
    }

    // Enemy class properties
    class Enemy
    {
        public string Type { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Player values
            Player player = new Player
            {
                Name = "Mathias",
                Health = 100,
                Level = 1
            };

            // Enemy values
            Enemy enemy = new Enemy
            {
                Type = "Goblin",
                Health = 50,
                Damage = 10
            };

            // Player property display
            Console.WriteLine("Player Info:");
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Level: {player.Level}");

            // Enemy property display
            Console.WriteLine("\nEnemy Info:");
            Console.WriteLine($"Type: {enemy.Type}");
            Console.WriteLine($"Health: {enemy.Health}");
            Console.WriteLine($"Damage: {enemy.Damage}");
        }
    }
}