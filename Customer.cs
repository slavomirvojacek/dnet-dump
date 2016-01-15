using System;
using System.Collections.Generic;
using System.Linq;

namespace main
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public string City;

        public Customer(string firstname, string lastname, string city)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.City = city;
        }

        public static void SelectCustomerData()
        {
            Customer[] customers = new Customer[] {
                new Customer("John", "Doe", "New York"),
                new Customer("Jason", "Statham", "London"),
                new Customer("Bob", "Statham", "London"),
                new Customer("Albus", "Dumbledore", "London")
            };

            // List is a subset of IEnumerable
            List<string> customerLastNameQuery = customers
                .Where(_ => _.City.Equals("London", StringComparison.OrdinalIgnoreCase))
                .Select(_ => _.LastName)
                .Distinct()
                .ToList();

            foreach (string LastName in customerLastNameQuery)
            {
                Console.WriteLine(LastName + " lives in London");
            }
        }
    }
}