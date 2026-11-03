using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Que15
    {
        public static void Run()
        {
            string?[] inputs =
            {
                "12",
                "abc",
                "",
                null,
                "999999999999"
            };

            // 1. int.Parse()

            Console.WriteLine("int.Parse() : ");
            
            foreach(string? input in inputs)
            {
                try
                {
                    int result = int.Parse(input);
                    Console.WriteLine($"Input: {Display(input)}, Success | Value : {result}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Input: {Display(input)}, Exception: {ex.GetType().Name}");
                }
            }

            // 2. int.TryParse()

            Console.WriteLine("int.TryParse()");

            foreach (string? input in inputs)
            {
                    bool success = int.TryParse(input, out int result);
                    Console.WriteLine($"Input: {Display(input)}, Success: {success} | Value : {result}");                
            }

            // 3. Convert.ToInt32()

            Console.WriteLine("Convert.ToInt32()");

            foreach (string? input in inputs)
            {
                try
                {
                    int result = Convert.ToInt32(input);
                    Console.WriteLine($"Input: {Display(input)}, Success | Value : {result}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Input: {Display(input)}, Exception: {ex.GetType().Name}");
                }
            }

            // 4. Accepting decimal unit price 

            Console.WriteLine("Unit Price input");

            Console.WriteLine("Enter unit price (use '.' as decimal seperator): ");

            string? price = Console.ReadLine();

            bool validPrice = decimal.TryParse(price, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal unitPrice);


            if( validPrice )
            {
                Console.WriteLine($"Accepted unit price : {unitPrice.ToString("0.00", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Invalid unit price");
            }
        }
        static string Display(string? input)
        {
            return input == null? "null": input;
        }
    }
}
