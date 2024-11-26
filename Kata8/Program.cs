// Player instance
Player player = new Player(name: "Mathias", health: 100, level: 1, experience: 0);

Console.WriteLine("Player Status:");
Console.WriteLine(
    $"Name: {player.Name}, Health: {player.Health}, Level: {player.Level}, Experience: {player.Experience}");

Console.WriteLine("\nPlayer gains 50 experience points:");
player.GainExperience(50);

Console.WriteLine("\nPlayer gains 60 experience points:");
player.GainExperience(60);


Console.WriteLine("\nSetting valid Level and Experience values:");
player.Level = 3;
player.Experience = 40;
Console.WriteLine($"Updated Player State: Level: {player.Level}, Experience: {player.Experience}");