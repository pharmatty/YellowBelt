namespace Minikata6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enemy name arrays
            string[] enemies = { "Goblin", "Orc", "Troll" };

            Console.WriteLine("Enemies:");
            foreach (string enemy in enemies)
            {
                Console.WriteLine(enemy);
            }

            // Listing of player inventory
            List<string> inventory = new List<string> { "Sword", "Shield", "Potion" };

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n*-*-*-*-*-*-*-*_*-*_*_*_*_*_*");
                Console.WriteLine("Player Inventory");
                Console.WriteLine("*-*-*-*-*-*-*-*_*-*_*_*_*_*_*");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Item to Inventory");
                Console.WriteLine("3. Remove Item from Inventory");
                Console.WriteLine("4. Exit");
                Console.WriteLine("*-*-*-*-*-*-*-*_*-*_*_*_*_*_*");
                Console.Write("Enter your choice: ");
                string choices = Console.ReadLine();

                switch (choices)
                {
                    case "1":
                        Console.WriteLine("\nPlayer Inventory:");
                        DisplayInventory(inventory);
                        break;

                    case "2":
                        Console.Write("\nEnter the name of the item to add: ");
                        string addItem = Console.ReadLine();
                        inventory.Add(addItem);
                        Console.WriteLine($"'{addItem}' has been added to your bag.");
                        break;

                    case "3":
                        Console.Write("\nEnter the name of the item to remove: ");
                        string removeItem = Console.ReadLine();
                        if (inventory.Remove(removeItem))
                        {
                            Console.WriteLine($"'{removeItem}' has been removed from your bag and placed in your storage.");
                        }
                        else
                        {
                            Console.WriteLine($"'{removeItem}' is not in your bag.");
                        }
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Farewell traveler!");
                        break;

                    default:
                        Console.WriteLine("Invalid, please select a different option warrior.");
                        break;
                }
            }
        }

        static void DisplayInventory(List<string> inventory)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Your inventory is empty.");
            }
            else
            {
                foreach (string item in inventory)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
