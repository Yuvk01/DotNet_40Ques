using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    class LegacyReport
    {
        // non-virtual method
        public void Display()
        {
            Console.WriteLine("Display Legacy Report");
        }

        // Virtual method
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Display Legacy Legacy Report Details");
        }
    }
    class DashboardReport : LegacyReport
    {
        // Hides the parent class display method
        public new void Display()
        {
            Console.WriteLine("Display Dashboard Report");
        }

        // Overrides the parent's virtual method
        public override void DisplayDetails()
        {
            Console.WriteLine("Displaying Dashboard Report Details");
        }
    }
    public class Ques30
    {
        static void Run()
        {
           
            DashboardReport dashboard = new DashboardReport();

            // Base class reference pointing to the same object
            LegacyReport legacy = dashboard;

            Console.WriteLine("---Method Hiding---");

            // calling through derived reference
            dashboard.Display();

            // calling through base class
            legacy.Display();

            Console.WriteLine("---Method Overriding---");

            // calling through derived reference
            dashboard.DisplayDetails();

            // calling through base class
            legacy.DisplayDetails();
        }
    }
}
