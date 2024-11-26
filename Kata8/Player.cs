public class Player
{
    private int _health;
    private int _level;
    private int _experience;

    public string Name { get; set; }

    // Health property
    public int Health
    {
        get => _health;
        private set => _health = value;
    }

    // Lvl. non negative value
    public int Level
    {
        get => _level;
        set
        {
            if (value >= 0)
                _level = value;
            else
                throw new ArgumentException("Level cannot be negative.");
        }
    }

    // Exp. non negative value
    public int Experience
    {
        get => _experience;
        set
        {
            if (value >= 0)
                _experience = value;
            else
                throw new ArgumentException("Experience cannot be negative.");
        }
    }

    // Constructor to initialize fields
    public Player(string name, int health, int level, int experience)
    {
        Name = name;
        _health = health;
        _level = level;
        _experience = experience;
    }

    // Exp method
    public void GainExperience(int exp)
    {
        Console.WriteLine($"Player {Name} gains {exp} experience points.");
        Experience += exp;
        if (Experience >= 100)
        {
            LevelUp();
        }
    }

    
    private void LevelUp()
    {
        Level++;
        Experience = 0;
        Console.WriteLine($"Congratulations! Player {Name} leveled up to Level {Level}.");
    }
}