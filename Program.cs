using System;
using System.Collections.Generic;
using System.Linq;

namespace main
{
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