using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class CardPayment {

        public string CardHolder {  get; set; }
        public string LastFourDegits { get; set; }
        public decimal Amount { get; set; }

        public CardPayment(string cardHolder, string lastFourDigits, decimal amount) { 
            CardHolder = cardHolder;
            LastFourDegits = lastFourDigits;
            Amount = amount;
        }
        
        public void DisplayDetails()
        {
            Console.WriteLine("Payment Type: Card Payment");
            Console.WriteLine($"Card Holder: {CardHolder}");
            Console.WriteLine($"Card Number: **** **** **** {LastFourDegits}");
            Console.WriteLine($"Amount : Rs. {Amount}");
        }
    }

    public class WalletPayment
    {
        public string WalletName { get; set; }
        public string MobileNumber { get; set; }
        public decimal Amount { get; set; }

        public WalletPayment(string walletName, string mobileNumber, decimal amount)
        {
            WalletName = walletName;
            MobileNumber = mobileNumber;
            Amount = amount;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Payment Type: Wallet Payment");
            Console.WriteLine($"Card Holder: {WalletName}");
            Console.WriteLine($"Card Number: {MobileNumber}");
            Console.WriteLine($"Amount : Rs. {Amount}");
        }
    }
    public class Ques8
    {
        public static void Run()
        {
            // Creating an object array containing mixed types

            object?[] payments =
            [
                new CardPayment("Yuv", "1234", 2500m),
                new WalletPayment("Google Pay", "9090123454", 1500m),
                "Cash",
                null
            ];

            // 2. Use is to identify supported payment objects and display their relevant details.

            foreach(object? payment in payments)
            {
                if(payment is CardPayment card)
                {
                    card.DisplayDetails();
                }
                else if(payment is WalletPayment walletPayment)
                {
                    walletPayment.DisplayDetails();
                }
                else if(payment==null)
                {
                    Console.WriteLine("Payment object is NULL.");
                }
                else
                {
                    Console.WriteLine("Unsupported payment type");
                }
            }

            // 3. Use as for a separate safe reference conversion and handle a failed conversion.

            object cardObject = new CardPayment("Rahul", "1245", 4000m);

            CardPayment? cardRef = cardObject as CardPayment;

            if(cardRef != null)
            {
                Console.WriteLine("Card conversion successful!");
                cardRef.DisplayDetails();
            }

            // Failed conversion 

            object walletObj = new WalletPayment("Paytm", "73462847687", 3000m);

            CardPayment? failed = walletObj as CardPayment;

            if(failed != null)
            {
                Console.WriteLine("Conversion Successful");
            }
            else
            {
                Console.WriteLine("Card conversion failed! Object is not a CardPayment.");
                Console.WriteLine("The result of as is null.");
            }
        }
    }
}
