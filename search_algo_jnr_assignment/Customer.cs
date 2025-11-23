using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_algo_jnr_assignment
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
    }

    internal class CustomerResponse
    {
        public Customer? Customer { get; set; }
        public int Index { get; set; }
        public int Steps { get; set; }
    }
}
