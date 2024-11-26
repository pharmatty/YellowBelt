namespace Kata6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enemy listing
            string[] enemies = { "Goblin", "Orc", "Troll", "Skeleton", "Dragon" };

            Console.WriteLine("Enemies:");
            foreach (string enemy in enemies)
            {
                Console.WriteLine(enemy);
            }

            // Initialized item list for the player
            List<string> inventory = new List<string> { "Sword", "Shield", "Potion" };
            
            // Items to add to inventory
            List<string> availableItems = new List<string> { "Helmet", "Armor", "Potion" };

            bool exit = false;

            while (!exit)
            {   //"Fancy" player interface 
                Console.WriteLine("*-*-*-*-*-*-*-*_*-*_*_*_*_*_*");
                Console.WriteLine("Player Inventory");
                Console.WriteLine("*-*-*-*-*-*-*-*_*-*_*_*_*_*_*");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Add Item to Inventory");
                Console.WriteLine("3. Remove Item from Inventory");
                Console.WriteLine("4. View Available Items to Add");
                Console.WriteLine("5. Exit");
                Console.WriteLine("*-*-*-*-*-*-*-*_*-*_*_*_*_*_*");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nPlayer Inventory:");
                        DisplayInventory(inventory);
                        Console.WriteLine($"\nTotal Items in your bag: {inventory.Count}");
                        break;

                    case "2":
                        Console.WriteLine("\nAvailable Items to Add:");
                        DisplayInventory(availableItems);
                        Console.Write("Enter the name of the item to add: ");
                        string addItem = Console.ReadLine();
                        if (availableItems.Contains(addItem))
                        {
                            inventory.Add(addItem);
                            Console.WriteLine($"'{addItem}' has been added to your bag.");
                        }
                        else
                        {
                            Console.WriteLine($"'{addItem}' is not available to add.");
                        }
                        break;

                    case "3":
                        Console.Write("\nEnter the name of the item to remove: ");
                        string removeItem = Console.ReadLine();
                        if (inventory.Remove(removeItem))
                        {
                            Console.WriteLine($"'{removeItem}' has been removed from your bag.");
                        }
                        else
                        {
                            Console.WriteLine($"'{removeItem}' is not in your inventory.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\nAvailable Items to Add:");
                        DisplayInventory(availableItems);
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Farewell warrior!");
                        break;

                    default:
                        Console.WriteLine("Invalid, pleace select another option.");
                        break;
                }
            }
        }

        static void DisplayInventory(List<string> items)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items to display.");
            }
            else
            {
                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
