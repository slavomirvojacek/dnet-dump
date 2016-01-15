using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            foreach (string k in GetUniqueValues())
            {
                Console.WriteLine("Value: {0}", k);
            }

            Console.Read();
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
    }
}
