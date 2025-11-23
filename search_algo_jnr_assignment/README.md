# ?? Assignment: Customer Lookup System — Linear Search

## ?? Overview
A small retail shop keeps its customer records in a simple list stored in memory. Each customer has:
- `CustomerId` (int)
- `Name` (string)
- `Email` (string)

The system does not use a database or any advanced search structure. The shop owner wants you to build a basic lookup feature using linear search.

---

## ?? Requirements

1. Create a Customer class with the properties above.
2. Create a list of at least 10 customers with realistic sample data.
3. Ask the user to enter:
- A CustomerId to search for.
- A Name to search for.

4. Implement two separate linear search methods:
- One that searches the list by CustomerId
- One that searches the list by Name (case-insensitive)


5. For each search:
- Return the customer object if found.
- Return null (or equivalent) if not found.
- Track and return the number of steps the search took.


6. Display output to the user:
- Whether the customer was found
- The customer’s details (if found)
- How many steps the linear search took


7. Test both searching by ID and searching by name with different inputs.