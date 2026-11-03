namespace _40Questions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. initialize values
            int invoice = 1001;
            decimal total = 2499.5m;
            bool paid = true;

            // 2. boxing : 
            object invoice_boxed = invoice;
            object total_boxed = total;
            object paid_boxed = paid;

            // and unboxing : 
            int unboxed_invoice = (int)invoice_boxed;
            decimal unboxed_total = (decimal)total_boxed;
            bool unboxed_paid = (bool)paid_boxed;

            // 3. boxed invoice treated as long instead of int : 
            try
            {

                long long_boxed_invoice = (long)invoice_boxed;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid unboxing");
            }

            // 4. Console Report :
             
            Console.WriteLine("Console Report : ");
            Console.WriteLine($"Invoice : Original Type - {invoice.GetType()}, Stored Value - {invoice}, Recovered type - {unboxed_invoice.GetType()}");
            Console.WriteLine($"Total : Original Type - {total.GetType()}, Stored Value - {total}, Recovered type - {unboxed_total.GetType()}");
            Console.WriteLine($"Paid Status : Original Type - {paid.GetType()}, Stored Value - {paid}, Recovered type - {unboxed_paid.GetType()}");
            
            Que2.Run();
            Que3.Run();
        }
    }
}
