using search_algo_intermediate_assignment;

Console.WriteLine("1. Search books by exact title");
Console.WriteLine("2. Search books by author (partial match)");
Console.WriteLine("3. Search books by genre");
Console.WriteLine("4. Search books published before a given year \n");
Console.Write("Select an option: ");
var userInput = Console.ReadLine();
Console.WriteLine("\n");

int optionNumber;
bool inputParsed= int.TryParse(userInput, out optionNumber);

if (inputParsed)
{
    var results = new SearchResponse();

    if (optionNumber == 1)
    {
        Console.Write("Enter Book Title: ");
        var title = Console.ReadLine();
        results = new BookSearchService().SearchByExactTitle(title);

        DisplayResults(results);
    }
    else if (optionNumber == 2)
    {
        Console.Write("Enter Author name: ");
        var author = Console.ReadLine();
        results = new BookSearchService().SearchByPartialAuthor(author);

        DisplayResults(results);
    }
    else if (optionNumber == 3)
    {
        Console.Write("Enter Genre: ");
        var genre = Console.ReadLine();
        results = new BookSearchService().SearchByExactGenre(genre);

        DisplayResults(results);
    }
    else if (optionNumber == 4)
    {
        Console.Write("Enter Year: ");
        var year = Console.ReadLine();
        results = new BookSearchService().SearchByBeforePublisedDate(int.Parse(year));

        DisplayResults(results);
    }
    else
    {
        Console.WriteLine("Invalid option!!");
    }
}
else
{
    Console.WriteLine("Not a valid number");
}


void DisplayResults(SearchResponse result)
{
    Console.WriteLine($"Results: {result.Books.Count}");
    Console.WriteLine($"Steps: {result.Steps}\n");

    Console.WriteLine("Books:");
    foreach (var book in result.Books)
    {
        Console.WriteLine($"[{book.BookId}] {book.Title}, by {book.Author} - {book.Genre} ({book.YearPublished})");
    }
}