using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 15 },
                new Person { Name = "Junior", Age = 1 },
                new Person { Name = "Ludimila", Age = 91 },
            };

            var ofLegalAge = person.Where(p => p.Age >= 18).OrderBy(p => p.Name).Select(p => p.Name);


            foreach (var name in ofLegalAge)
            {
                Console.WriteLine($"Person with legal age: {name}");
            }
        }
    }
}
