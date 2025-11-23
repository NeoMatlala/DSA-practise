// Linear search implementation with step count as well

int target = 5;
int[] arr = new int[4] { 4,7,8,5};

var result = LinearSearchAlgo(arr, target);

if(result.Index != -1)
{
    Console.WriteLine($"{target} found\nIndex: {result.Index}\nSteps: {result.Steps}");
}
else
{
    Console.WriteLine($"{target} not found in array!\nSteps: {result.Steps}");
}



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