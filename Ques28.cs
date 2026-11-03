using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class DeliveryService
    {
        public virtual decimal Charge(decimal distance)
        {
            Validation(distance);
            Console.WriteLine("Delivery service Charge");
            return 50 + (10*distance);
        }

        public void Validation(decimal distance)
        {
            if(distance < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(distance), "distance cannot be negative");
            }
        }
    }

    public class StandardDelivery: DeliveryService
    {
        public override decimal Charge(decimal distance)
        {
            Console.WriteLine("Standard Delivery Charge");
            // using base class calculation
            return base.Charge(distance);
        }
    }
    public class ExpressDelivery: DeliveryService
    {
        public override decimal Charge(decimal distance)
        {
            Validation(distance);
            Console.WriteLine("Express Delivery Charge");
            return 100 + (15 * distance);
        }
    }
    public class Ques28
    {
        static void Run()
        {
            DeliveryService standard = new StandardDelivery();
            DeliveryService express = new ExpressDelivery();

            decimal[] distances = { 0, 5, 12 };

            foreach(decimal distance in distances)
            {
                
            }

            // Testing negative distance 

            try
            {
                standard.Charge(-4);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
