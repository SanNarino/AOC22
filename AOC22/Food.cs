namespace AOC22;

public class Food
{
    private int id;
    private int calories;
    
    // Constructor
    public Food(int id, int calories)
    {
        this.id = id;
        this.calories = calories;
    }
    
    //setters and getters
    public int Id
    {
        get => id;
        set => id = value;
    }

    public int Calories
    {
        get { return calories; }
        set { calories = value; }
    }
    
    
}