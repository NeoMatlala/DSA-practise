// Linear search implementation with step count as well

string target = "Neo";
var arr = new string[5] { "Lerato", "Zakhele", "Mponeng", "Marematlou", "neo"};

var result = StringLinearSearch(arr, target);

if(result.Index != -1)
{
    Console.WriteLine($"{target} found\nIndex: {result.Index}\nSteps: {result.Steps}");
}
else
{
    Console.WriteLine($"{target} not found in array!\nSteps: {result.Steps}");
}


// for strings
LinearSearchResponse StringLinearSearch(string[] arr, string target)
{
    int index = -1;
    int steps = 0;

    for (int s = 0; s <= arr.Length -1; s++)
    {
        steps++;

        if (arr[s].Equals(target, StringComparison.OrdinalIgnoreCase))
        {
            index = s;
            break;
        }
    }

    return new LinearSearchResponse
    {
        Index = index,
        Steps = steps,
    };
}



// for integers
LinearSearchResponse LinearSearchAlgo(int[] arr, int targetValue)
{
    int index = -1;
    int steps = 0;

    for(int i = 0; i <= arr.Length - 1; i++)
    {
        steps++;

        if (arr[i] == targetValue)
        {
            index = i;
            break;
        }
    }

    return new LinearSearchResponse
    {
        Index = index,
        Steps = steps
    };
}

public class LinearSearchResponse
{
    public int Steps { get; set; }
    public int Index { get; set; }
}