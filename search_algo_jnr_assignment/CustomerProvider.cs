using search_algo_jnr_assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search_algo_jnr_assignment
{
    internal class CustomerProvider
    {
        private Customer[] _customers = new Customer[]
        {
            new Customer { CustomerId = 101, Name = "Thabo Mokoena", Email = "thabo.mokoena@example.com" },
            new Customer { CustomerId = 102, Name = "Lerato Khumalo", Email = "lerato.khumalo@example.com" },
            new Customer { CustomerId = 103, Name = "Neo Matlala", Email = "neo.matlala@example.com" },
            new Customer { CustomerId = 104, Name = "Sipho Dlamini", Email = "sipho.dlamini@example.com" },
            new Customer { CustomerId = 105, Name = "Anika van der Merwe", Email = "anika.vdmerwe@example.com" },
            new Customer { CustomerId = 106, Name = "Jade Govender", Email = "jade.govender@example.com" },
            new Customer { CustomerId = 107, Name = "Kabelo Molefe", Email = "kabelo.molefe@example.com" },
            new Customer { CustomerId = 108, Name = "Zanele Mthembu", Email = "zanele.mthembu@example.com" },
            new Customer { CustomerId = 109, Name = "Imran Patel", Email = "imran.patel@example.com" },
            new Customer { CustomerId = 110, Name = "Marius Botha", Email = "marius.botha@example.com" }
        };

        public Customer[] GetAllCustomers()
        {
            return _customers;
        }

        public CustomerResponse GetCustomerByID(int id)
        {
            int index = -1;
            int steps = 0;
            Customer customer = null;


            for (int i = 0; i <= _customers.Length -1; i++)
            {
                steps++;

                if (_customers[i].CustomerId == id)
                {
                    index = i;
                    customer = _customers[i];
                    break;
                }
            }

            return new CustomerResponse
            {
                Customer = customer,
                Index = index,
                Steps = steps
            };
        }

        public CustomerResponse GetCustomerByName(string customerName)
        {
            Customer customer = null;
            int index = -1;
            int steps = 0;

            for (int i = 0; i <= _customers.Length - 1; i++) 
            {
                steps++;

                if (_customers[i].Name.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                {
                    customer = _customers[i];
                    index = i;
                    break;
                }
            }

            return new CustomerResponse
            {
                Customer = customer,
                Index = index,
                Steps = steps
            };
        }
    }
}
