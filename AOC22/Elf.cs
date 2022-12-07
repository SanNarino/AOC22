namespace AOC22;

public class Elf
{
    private int id;
    private string name;
    private List<Food> foods;

    // constructor
    public Elf(int id, string name)
    {
        this.id = id;
        this.name = name;
        this.foods = new List<Food>();
    }
    
    // getters and setters
    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public List<Food> Foods
    {
        get => foods;
        set => foods = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    
}