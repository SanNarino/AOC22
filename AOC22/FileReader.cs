namespace AOC22;

public class FileReader
{
    public static int[] Reader(string filename)
    {
        var input = File.ReadAllLines("C:\\Users\\33448\\Desktop\\Programming\\AOC22\\AOC22\\Files\\" + filename + ".txt");
        int[] inputArray = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] != "")
            {
                inputArray[i] = int.Parse(input[i]);
            }
            else
            {
                inputArray[i] = 0;
            }
        }
        return inputArray;
    }
}