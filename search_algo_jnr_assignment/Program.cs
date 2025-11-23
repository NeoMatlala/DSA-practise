/*
 JNR level looup assignemt.
Search for a customer via CustomerId or Customer Name
 
 */

using search_algo_jnr_assignment;

Console.Write("Customer to search: ");
var customer = Console.ReadLine();
int customerID;

bool isNumber = int.TryParse(customer, out customerID);

if (isNumber)
{
    var provider = new CustomerProvider();
    var result = provider.GetCustomerByID(customerID);
    DisplayResponse(result);
}
else
{
    var provider = new CustomerProvider();
    var result = provider.GetCustomerByName(customer);
    DisplayResponse(result);
}

void DisplayResponse(CustomerResponse response)
{
    if (response.Customer != null)
    {
        Console.WriteLine($"\n[{response.Customer.CustomerId}] {response.Customer.Name}, {response.Customer.Email}\nSteps: {response.Steps}");
    }
    else
    {
        Console.WriteLine("\ncustomer not found");
    }
}