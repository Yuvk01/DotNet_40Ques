using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Que9
    {
        public static void Run()
        {
            int currentStock = 50;

            string[] testInputs = { "15", "-20", "-60", "invalid_number" };

            Console.WriteLine($"Initial Inventory Stock: {currentStock}\n");

            foreach (var input in testInputs)
            {
                Console.WriteLine($"Processing Input Action: '{input}'");
                Console.WriteLine($"Stock BEFORE attempt: {currentStock}");

                // 1: Use 'out' to validate raw text input safely
                if (TryValidateQuantity(input, out int validatedAmount))
                {// 2: Use 'ref' to modify existing stock variable
                    bool isAdjusted = TryAdjustStock(ref currentStock, validatedAmount);

                    if (isAdjusted)
                    {
                        Console.WriteLine($"   Result: SUCCESS. Applied adjustment of {validatedAmount}.");
                    }
                    else
                    {
                        Console.WriteLine($"   Result: REJECTED. Adjustment ({validatedAmount}) would drop stock below zero.");
                    }
                }
                else
                {
                    Console.WriteLine("   Result: FAILED. The input quantity could not be parsed.");
                }
                Console.WriteLine($"Stock AFTER attempt: {currentStock}");
                Console.WriteLine(new string('-', 50));
            }
        }

        // Validates raw string input and supplies the numerical quantity through an out parameter.
        public static bool TryValidateQuantity(string input, out int quantity)
        {
            return int.TryParse(input, out quantity);
        }

        // Modifies the existing stock value using ref, guarding against negative totals.
        
        public static bool TryAdjustStock(ref int stock, int adjustment)
        {
            // ref parameter already has an allocated, initialized value coming into the method.
            if (stock + adjustment < 0)
            {
                return false;
            }
            stock += adjustment; // Directly mutates the caller's variable
            return true;
        }
    }
}
