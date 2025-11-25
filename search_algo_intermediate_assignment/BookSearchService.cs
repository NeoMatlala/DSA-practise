using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_algo_intermediate_assignment
{
    internal class BookSearchService
    {
        private List<Book> _books = new BookRepository().GetAllBooks();

        public BookSearchService() 
        {
            
        }

        // Search by Exact Title
        public SearchResponse SearchByExactTitle(string bookTitle)
        {
            //var booksFromRepository = new BookRepository().GetAllBooks();

            int steps = 0;
            var bookMatches = new List<Book>(); 

            for (int i = 0; i <= _books.Count - 1; i++)
            {
                steps++;

                if (_books[i].Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase))
                {
                    bookMatches.Add(_books[i]);
                }
            }

            return new SearchResponse
            {
                Books = bookMatches,
                Steps = steps
            };

        }


        // Search by Author (partial match)
        public SearchResponse SearchByPartialAuthor(string authorSubString)
        {
            int steps = 0;
            var bookMatches = new List<Book>();

            for (int i = 0; i <= _books.Count - 1; i++)
            {
                steps++;

                if (_books[i].Author.Contains(authorSubString, StringComparison.OrdinalIgnoreCase))
                {
                    bookMatches.Add(_books[i]);
                }
            }

            return new SearchResponse
            {
                Books = bookMatches,
                Steps = steps
            };
        }


        // Search by Genre
        public SearchResponse SearchByExactGenre(string genre)
        {
            int steps = 0;
            var bookMatches = new List<Book>();

            for (int i = 0; i <= _books.Count - 1; i++)
            {
                steps++;

                if (_books[i].Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                {
                    bookMatches.Add(_books[i]);
                }
            }

            return new SearchResponse
            {
                Books = bookMatches,
                Steps = steps
            };
        }


        // Search for Books Published Before a Given Year
        public SearchResponse SearchByBeforePublisedDate(int yearPublished)
        {
            int steps = 0;
            var bookMatches = new List<Book>();

            for (int i = 0; i <= _books.Count - 1; i++)
            {
                steps++;

                if (_books[i].YearPublished < yearPublished)
                {
                    bookMatches.Add(_books[i]);
                }
            }

            return new SearchResponse
            {
                Books = bookMatches,
                Steps = steps
            };
        }
    }

    internal class SearchResponse
    {
        public List<Book> Books { get; set; }
        public int Steps { get; set; }
    }
}
