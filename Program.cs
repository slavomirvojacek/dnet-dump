using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                .Where(_ => _.City == "London")
                .Select(_ => _.LastName)
                .Distinct()
                .ToList();

            foreach (string LastName in customerLastNameQuery)
            {
                Console.WriteLine(LastName + " lives in London");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("");

            foreach (string k in GetUniqueValues())
            {
                Console.WriteLine("Value: {0}", k);
            }

            Console.WriteLine("");

            Ints();

            Console.WriteLine("\n");

            Customer.SelectCustomerData();

            // Console.Read();
        }

        private static HashSet<string> GetUniqueValues()
        {
            Dictionary<string, string> obj = new Dictionary<string, string>()
            {
                {"a", "Hello"}, {"b", "World"}, {"c", "Hello"}, {"d", "World"}
            };

            List<string> list = new List<string>(obj.Values);

            return new HashSet<string>(list);
        }

        private static void Ints()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }   
    }
}