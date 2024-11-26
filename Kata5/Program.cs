namespace Kata5
{
    class Program
    {
        // Attack property
        static void AttackEnemy(string enemyName, int damage)
        {
            Console.WriteLine($"Attacked {enemyName} and dealt {damage} damage!");
        }

        // Heal property
        static void HealPlayer(string playerName, int healAmount)
        {
            Console.WriteLine($"Player {playerName} healed {healAmount} HP!");
        }

        static void Main(string[] args)
        {
            
            AttackEnemy("Goblin", 15);

            
            HealPlayer("Arin", 10);
            
        }
    }
}