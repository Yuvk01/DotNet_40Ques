using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Que2
    {
        public static void Run()
        {
            // 1. Daily sales : 
            int[] sales = { 12500, 9800, 15400, 8700, 19100, 16800, 11200 };

            // 2. Accept a sales target
            Console.WriteLine("Enter Sales Target : ");
            int target = int.Parse(Console.ReadLine()); // OR Convert.ToInt32

            // Days that meet or exceed the target : 
            int sales_length = sales.Length;
            bool flag = false;
            Console.WriteLine("Days meeting or exceeding the target : ");
            for(int i=0;i< sales_length; i++)
            {
                if(sales[i] >= target)
                {
                    Console.WriteLine($"Day {i+1}: {sales[i]} INR Sales");
                    flag = true;
                }
            }
            if (!flag)
                Console.WriteLine("No days met the target");

            // Total, average, highest and lowest sales : 
            int total = 0; decimal average = 0;
            int highest = sales[0], lowest = sales[0];
            for(int i=0;i< sales_length; i++)
            {
                total += sales[i];

                if(sales[i] > highest)
                    highest= sales[i];

                if(sales[i] < lowest)
                    lowest= sales[i];
            }
            average = total / sales_length;

            Console.WriteLine("Sales Summary : ");
            Console.WriteLine($"Total Sales : {total}");
            Console.WriteLine($"Highest Sales : {highest}");
            Console.WriteLine($"Lowest Sales : {lowest}");
            Console.WriteLine($"Average Sales : {average}");

            // 4. Test with repeated highest values and identify every matching day

            int[] test_sales = { 15000, 15000, 18000, 8700, 18000, 16800, 11200 };

            int highest_test = test_sales[0];
            for (int i = 0; i < sales_length; i++)
            {
                if (test_sales[i] > highest_test)
                    highest_test = test_sales[i];
            }
            Console.WriteLine("Highest sales day : ");
            for (int i = 0; i < sales_length; i++)
            {
                if (highest_test == test_sales[i])
                    Console.WriteLine("Day {i+1} : {test_sales}");
            }
        }
    }
}
