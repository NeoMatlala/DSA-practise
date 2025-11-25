using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_algo_intermediate_assignment
{
    internal class BookRepository
    {
        private List<Book> _books = new List<Book>
        {
            new Book { BookId = 1, Title = "Shadows Over Table Mountain", Author = "Lindiwe Khumalo", Genre = "Mystery", YearPublished = 2018, isAvailable = true },
            new Book { BookId = 2, Title = "The Karoo Wanderer", Author = "Pieter van der Westhuizen", Genre = "Adventure", YearPublished = 2015, isAvailable = false },
            new Book { BookId = 3, Title = "Rainfall in June", Author = "Naledi Mokoena", Genre = "Drama", YearPublished = 2020, isAvailable = true },
            new Book { BookId = 4, Title = "Echoes of District Six", Author = "Samuel Arendse", Genre = "Historical Fiction", YearPublished = 2012, isAvailable = true },
            new Book { BookId = 5, Title = "Under the Baobab Sky", Author = "Thabo Dlamini", Genre = "Cultural Fiction", YearPublished = 2017, isAvailable = false },
            new Book { BookId = 6, Title = "Waves of Muizenberg", Author = "Chloe Jacobs", Genre = "Romance", YearPublished = 2021, isAvailable = true },
            new Book { BookId = 7, Title = "The Durban Tide", Author = "Imran Essop", Genre = "Thriller", YearPublished = 2019, isAvailable = false },
            new Book { BookId = 8, Title = "A Walk Through Soweto", Author = "Bongani Mthembu", Genre = "Non-Fiction", YearPublished = 2011, isAvailable = true },
            new Book { BookId = 9, Title = "Whispers of the Kalahari", Author = "Thabo Dlamini", Genre = "Adventure", YearPublished = 2016, isAvailable = true },
            new Book { BookId = 10, Title = "Last Train to Cape Town", Author = "Michael Snyman", Genre = "Thriller", YearPublished = 2014, isAvailable = false },
            new Book { BookId = 11, Title = "Protea Fields Forever", Author = "Jessica Nong", Genre = "Romance", YearPublished = 2022, isAvailable = true },
            new Book { BookId = 12, Title = "The Cradle Mystery", Author = "Rufus Khuzwayo", Genre = "Mystery", YearPublished = 2013, isAvailable = true },
            new Book { BookId = 13, Title = "Northern Drakensberg Nights", Author = "Anika Coetzee", Genre = "Fantasy", YearPublished = 2010, isAvailable = false },
            new Book { BookId = 14, Title = "Marula Harvest", Author = "Thabo Dlamini", Genre = "Cultural Fiction", YearPublished = 2017, isAvailable = true },
            new Book { BookId = 15, Title = "The Johannesburg Heist", Author = "Zanele Mahlangu", Genre = "Crime", YearPublished = 2019, isAvailable = true },
            new Book { BookId = 16, Title = "Footprints in Limpopo", Author = "Sibusiso Shabalala", Genre = "Travel", YearPublished = 2009, isAvailable = true },
            new Book { BookId = 17, Title = "Midnight on Long Street", Author = "Gerhard Pretorius", Genre = "Crime", YearPublished = 2015, isAvailable = false },
            new Book { BookId = 18, Title = "Wild Coast Secrets", Author = "Ameera Moosa", Genre = "Adventure", YearPublished = 2020, isAvailable = true },
            new Book { BookId = 19, Title = "Beyond the Veld", Author = "Thabo Dlamini", Genre = "Drama", YearPublished = 2018, isAvailable = false },
            new Book { BookId = 20, Title = "The Lion Scholar", Author = "Siphesihle Ngqola", Genre = "Children’s", YearPublished = 2013, isAvailable = true }
        };

        public List<Book> GetAllBooks()
        {
            return _books;
        }
        
    }
}
