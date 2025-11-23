/*
 
 BINARY SEARCH IN UNSORTED LIST

Write function that takes and ordered List and a target value.

- return index of target if it exists
- return -1 otherwise
- measure number of halving steps were made


 */


var numbers = new List<int>() { 2,3,5,6,8,9};
int BinaryTarget = 8;

SearchBinary(numbers, BinaryTarget);

void SearchBinary(List<int> nums, int target)
{
    // binary search: 
    // take list and get number in middle- if less than half, means number is LHS so create new copyand do same until you find target

    // middle in even list is first of two middle values

    int targetIndex = -1;

    // 1st get middle value
    int middleIndex = (nums.Count - 1 ) / 2;
    int middleValue = nums[middleIndex];

    if (target == middleValue)
    {
        targetIndex = middleIndex;

    }
    else if(target < middleValue)
    {
        // focus on the LHS
        // create new array from[0] till middle value, and do the same decision
        Console.WriteLine($"Left");
    } 
    else if( target > middleValue)
    {
        // focus on RHS
        Console.WriteLine($"Right");

    }

    Console.WriteLine($"Index: {targetIndex}");
}































/*
 
 LINEAR SEARCH IN UNSORTED LIST

Write function that takes and unordered List and a target value.

- return index of target if it exists
- return -1 otherwise
- measure number of comparisons made


 */

var unsortedList = new List<int>() { 2,4,5,6,9,8,0,10,65};
int target = 10;

var names = new List<string> { "Neo", "Hlogi", "Puleng", "Lebo", "Thato"};
var namesTarget = "Lebo";

var result = SearchForIndex(unsortedList, 65);

//Console.WriteLine($"Names Target: {namesTarget}");
//Console.WriteLine($"Names List Length: {names.Count}\n");
//SearchForName(names, namesTarget);

void SearchForName(List<string> names, string targetName)
{
    int targetIndex = -1;
    int comparisons = 0;

    for (int i = 0; i <= names.Count - 1; i++)
    {
        comparisons++;
        
        if (names[i].ToLower() == targetName.ToLower())
        {
            targetIndex = i;
            break;
        }
    }

    Console.WriteLine($"Target: {targetIndex}");
    Console.WriteLine($"Comparisons: {comparisons}");
}



SearchType SearchForIndex(List<int> unsortedList, int target)
{
    int index = -1;
    int comparisons = 0;

    for (int i = 0; i <= unsortedList.Count - 1; i++)
    {
        if (unsortedList[i] == target)
        {
            index = i;
            break;
        }
        comparisons++;
    }

    SearchType response = new SearchType
    {
        IndexFound = index,
        Comparisons = comparisons
    };

    return response;
}

public class SearchType
{
    public int IndexFound { get; set; }
    public int Comparisons { get; set; }
}