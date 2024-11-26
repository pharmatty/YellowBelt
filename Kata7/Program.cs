class Program
{
    static void Main(string[] args)
    {
        // Player Inst.
        Player player = new Player
        {
            Name = "Mathias",
            Health = 100,
            Level = 1,
            Experience = 0
        };

        // Enemy Inst.
        Enemy enemy = new Enemy
        {
            Type = "Orc",
            Health = 50,
            Damage = 10
        };

        // Battle Engagement
        Console.WriteLine("You've entered a battle!");
        
        player.Attack(enemy, 20);
        
        player.GainExperience(50);

        Console.WriteLine("Victory!");
    }
}