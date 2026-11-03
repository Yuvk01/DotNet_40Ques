//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _40Questions
//{
//    internal class Ques27
//    {
//    }
//}


using System;
using System.Collections.Generic;

namespace RestaurantOrderEntry
{
    // 1. Represents a line item inside a customer's receipt
    public class OrderLine
    {
        public string ItemName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public string? SpecialInstruction { get; set; } // Nullable if no instruction is provided

        public decimal LineTotal => Quantity * PricePerUnit;

        public override string ToString()
        {
            string instructionText = !string.IsNullOrWhiteSpace(SpecialInstruction)
                ? $" (*Notes: {SpecialInstruction})"
                : "";
            return $"{Quantity}x {ItemName} @ ${PricePerUnit:F2} = ${LineTotal:F2}{instructionText}";
        }
    }

    public class OrderManager
    {
        // Fixed menu with items and their prices
        private static readonly Dictionary<string, decimal> Menu = new(StringComparer.OrdinalIgnoreCase)
        {
            { "Burger", 8.99m },
            { "Pizza", 12.50m },
            { "Fries", 3.49m },
            { "Soda", 1.99m }
        };

        private readonly List<OrderLine> _orderLines = new();

        // --- Overload 1: Item alone (Defaults to a quantity of 1 with no instruction) ---
        public void AddItem(string itemName)
        {
            AddItem(itemName, 1, null);
        }

        // --- Overload 2: Item with explicit quantity (No instruction) ---
        public void AddItem(string itemName, int quantity)
        {
            AddItem(itemName, quantity, null);
        }

        // --- Overload 3: Item with quantity AND special instruction ---
        // This is the core implementation method that contains the validation logic
        public void AddItem(string itemName, int quantity, string? specialInstruction)
        {
            // Validation 1: Reject unknown menu items
            if (!Menu.TryGetValue(itemName, out decimal price))
            {
                Console.WriteLine($"[ERROR] Rejected: '{itemName}' is not on our menu.");
                return;
            }

            // Validation 2: Reject non-positive quantities (<= 0)
            if (quantity <= 0)
            {
                Console.WriteLine($"[ERROR] Rejected: Quantity for '{itemName}' must be greater than zero.");
                return;
            }

            // Create and store the valid order line
            _orderLines.Add(new OrderLine
            {
                ItemName = itemName,
                Quantity = quantity,
                PricePerUnit = price,
                SpecialInstruction = specialInstruction
            });

            Console.WriteLine($"[SUCCESS] Added {quantity}x {itemName} to the order.");
        }

        // Displays final summary and total price
        public void PrintReceipt()
        {
            Console.WriteLine("\n================ RECEIPT ================");
            decimal totalOrderCost = 0;

            foreach (var line in _orderLines)
            {
                Console.WriteLine(line.ToString());
                totalOrderCost += line.LineTotal;
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"TOTAL DUE: ${totalOrderCost:F2}");
            Console.WriteLine("=========================================\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderManager order = new OrderManager();

            Console.WriteLine("=== Processing Restaurant Order ===\n");

            // 1. Call Overload 1: Item Alone
            order.AddItem("Burger");

            // 2. Call Overload 2: Item with Quantity
            order.AddItem("Soda", 3);

            // 3. Call Overload 3: Item with Quantity and Special Instruction
            order.AddItem("Pizza", 2, "Extra cheese, well done");

            // 4. Test Error Handling: Invalid items and negative quantities
            order.AddItem("Tacos"); // Unknown item
            order.AddItem("Fries", -2); // Non-positive quantity

            // Print final results to verify instruction scoping and totals
            order.PrintReceipt();
        }
    }
}
