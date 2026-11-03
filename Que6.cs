using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Que6
    {
        public static void Run()
        {
            // 1. 
            var itemCode = "WH-A01";
            var quantity = 100;
            var unitPrice = 2500;
            var quantities = new[] { 10, 20, 50, 10, 100 };

            // 2. 
            decimal inventory = quantity * unitPrice;
            Console.WriteLine($"Item code type : {itemCode.GetType()}, value : {itemCode}");
            Console.WriteLine($"Quantity type : {quantity.GetType()}, value : {quantity}");
            Console.WriteLine($"Unit Price type : {unitPrice.GetType()}, value : {unitPrice}");
            Console.WriteLine($"Quantity array type : {quantities.GetType()}, value : {quantities}");

            // 3. Update quantities 
            quantity = 30;
            quantities[0] = 25;
            quantities[3] = 35;

            // 4. 
            // quantity = "no";
            // quantities[0]="hello";

        }
    }
}
