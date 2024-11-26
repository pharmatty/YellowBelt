namespace MiniKata5
{
    class Program
    {
        
        public static void Attack(int damage)
        {
            Console.WriteLine($"Player dealt {damage} damage!");
        }

        
        public static void Heal(int healAmount)
        {
            Console.WriteLine($"Player healed {healAmount} health points!");
        }

        static void Main(string[] args)
        {
            // Attack/heal methods
            Attack(15); 
            Heal(10);   
        }
    }
}