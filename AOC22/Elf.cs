namespace AOC22;

public class Elf
{
    private int id;
    private string name;
    private List<Food> food;
    private List<int> foodAmount;
    
    // constructor
    public Elf(int id, string name)
    {
        this.id = id;
        this.name = name;
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

    public int FoodAmount
    {
        get => food.Count;
    }

    public List<Food> Food
    {
        get => food;
        set => food = value ?? throw new ArgumentNullException(nameof(value));
    }
}