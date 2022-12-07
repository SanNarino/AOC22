namespace AOC22;


public class Day1
{
    public static void Main(string[] args)
    {

        int[] input = FileReader.Reader("Day1");
        
        var sum = 0;
        var count = 0;
        int j = 0;
        
        List<Elf> elfs = new List<Elf>();

        elfs.Add(new Elf(count, "Elf Nr. " + count));

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == 0)
            {
                j = 0;
                sum = 0;
                count++;
                elfs.Add(new Elf(count, "Elf Nr. " + count));

            }
            else
            {
                elfs[count].Foods.Add(new Food(j + 1, input[i]));  
                sum += input[i];
                j++;
            }
            Console.WriteLine(i);
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
        
        foreach (var elf in elfs)
        {
            Console.WriteLine(elf.Name);
            foreach (var food in elf.Foods)
            {
                Console.WriteLine(food.Id + " " + food.Calories);
            }
            Console.WriteLine(elf.Foods.Sum(x => x.Calories));
        }
        elfs.Sort((x, y) => x.Foods.Sum(z => z.Calories).CompareTo(y.Foods.Sum(z => z.Calories)));
        Console.WriteLine(elfs[elfs.Count-1].Name);
        Console.WriteLine(elfs[elfs.Count-1].Foods.Sum(x => x.Calories)); }
}