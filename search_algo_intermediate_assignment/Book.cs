using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_algo_intermediate_assignment
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
        public bool isAvailable { get; set; }
    }
}
