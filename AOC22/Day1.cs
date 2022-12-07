namespace AOC22;

public class Day1
{
    public static void Main(string[] args)
    {
        var input = File.ReadAllLines("C:\\Users\\33448\\Desktop\\Programming\\AOC22\\AOC22\\Day1_input.txt");

        var sum = 0;
        int nOfFood = 1;
        var count = 0;
        
        List<Elf> elfs = new List<Elf>();
        //for loop that goes through each line and counts number of empty lines
        elfs.Add(new Elf(count, "Elf Nr. " + count));

        for (int i = 0; i < input.Length; i++)
        {

            if (input[i] == "" || input[i].Equals(input.Length - 1) || i != 0)
            {
                count++;
                elfs.Add(new Elf(count, "Elf Nr. " + count));
                sum = 0;
            }
            else
            {
                Food food = new Food(sum, Int32.Parse(input[i]));
                elfs[count].Food.Add(food);
                sum += elfs[i].Food[nOfFood].Calories;
                nOfFood++;
                Console.WriteLine(elfs[0].Name);
                Console.WriteLine(elfs[0].Food.Count);
                Console.WriteLine(elfs[0].Food[0].Calories);
            }
        }
        
        Console.WriteLine(elfs.Count);
        Console.WriteLine(elfs[0].Name);
        Console.WriteLine(elfs[0].Food.Count);
        Console.WriteLine(elfs[0].Food[0].Calories);
        Console.WriteLine(elfs[1].Name);
        Console.WriteLine(elfs[200].Name);
        Console.WriteLine(elfs[count-1].Name);
    }
}