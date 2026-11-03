using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    public class Que11
    {
        public static void Run()
        {
            Customer customer1 = new Customer(15, "Gogi");
            Customer customer2 = new Customer(15, "Gogi");
            Customer customer3 = customer1;

            Console.WriteLine("Customer 1 and customer 2 : ");
            Console.WriteLine($"Using == : {customer1 == customer2}");
            Console.WriteLine($"Using Equals : {customer1.Equals(customer2)}");

            Console.WriteLine("Customer 1 and customer 3 : ");
            Console.WriteLine($"Using == : {customer1 == customer3}");
            Console.WriteLine($"Using Equals : {customer1.Equals(customer3)}");

            string s1 = new string("Mogli");
            string s2 = new string("Mogli");

            object obj1 = s1;
            object obj2 = s2;

            Console.WriteLine("String 1 and string 2 : ");
            Console.WriteLine($"Using == : {s1 == s2}");
            Console.WriteLine($"Using Equals : {s1.Equals(s2)}");

            Console.WriteLine("Object 1 and object 3 : ");
            Console.WriteLine($"Using == : {obj1 == obj2}");
            Console.WriteLine($"Using Equals : {obj1.Equals(obj2)}");
        }
    }
}
