using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public interface IPrinter
    {
        void Print(string doc);
    }
    public interface IScanner
    {
        void Scan();
    }
    public interface IMultiFunctionDevice: IPrinter, IScanner
    {
    }

    public class MultiFunctionDevice : IMultiFunctionDevice
    {
        public void Print(string doc)
        {
            Console.WriteLine("Multifunction printer : Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("Multifunction printer : Scanning...");
        }
    }
    class BasicPrinter : IPrinter
    {
        public void Print(string doc)
        {
            Console.WriteLine("Printing document...");
        }
    }
    public class Que33
    {
        public static void Run()
        {
            // creating objects
            BasicPrinter basicPrinter = new BasicPrinter();

            MultiFunctionDevice multiPrinter = new MultiFunctionDevice();

            // Basic printer
            basicPrinter.Print("Report.pdf");

            // Multifunction printer
            multiPrinter.Print("Device.pdf");
            multiPrinter.Scan();




            // using IPrinter

            //Console.WriteLine("Printer Operations");

            //IPrinter printer1 = basicPrinter;
            //IPrinter printer2 = multiPrinter;

            //UsePrinter(printer1);
            //UsePrinter(printer2);

            //// Using IScanner 
            //Console.WriteLine("Scanner Operations");

            //IScanner scanner = multiPrinter;
            //UseScanner(scanner);

            //// Using IMultiFunctionDevice
            //Console.WriteLine("MultiFunction Operations");

            //IMultiFunctionDevice device = multiPrinter;

            //UseMultiFunction(device);

            // Invalid assignment 

            // BasicPrinter implements only IPrinter.
            // It does not implement IScanner

            // IScanner invalidScanner = basicPrinter;

            // The above statement produces a compile time error because BasicPrinter does not implement IScanner
        }
        //static void UsePrinter(IPrinter printer)
        //{
        //    printer.Print("Report.pdf");
        //}
        //static void UseScanner(IScanner scanner)
        //{
        //    scanner.Scan();
        //}
        //static void UseMultiFunction(IMultiFunctionDevice device)
        //{
        //    device.Print("Device.pdf");
        //    device.Scan();
        //}
    }
}
