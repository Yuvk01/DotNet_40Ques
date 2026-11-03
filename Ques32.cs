using System;

namespace _40Questions
{
    // 1. INotifier Interface
    public interface INotifier
    {
        void SendNoti(string recipient, string message);
    }

    // 2. Implement the Email Notifier
    public class EmailNotifier : INotifier
    {
        public void SendNoti(string recipient, string message)
        {
            Console.WriteLine("Channel : Email");
            Console.WriteLine("Recipent : "+ recipient);
            Console.WriteLine("Message : "+message);
        }
    }

    // 3. Implement the SMS Notifier
    public class SmsNotifier : INotifier
    {
        public void SendNoti(string recipient, string message)
        {
            Console.WriteLine("Channel : SMS");
            Console.WriteLine("Recipent : " + recipient);
            Console.WriteLine("Message : " + message);
        }
    }

    class Ques32
    {
        static void ProcessNotifications(INotifier notifier,string recipient, string message)
        {
            // Validate recipient
            if(string.IsNullOrWhiteSpace(recipient))
            {
                throw new ArgumentException("Reciepent cannot be blank.");
            }

            // Validate message 
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Message cannot be blank.");
            }
            notifier.SendNoti(recipient, message);
        }
        public static void Run()
        {
            INotifier email = new EmailNotifier();
            INotifier sms = new SmsNotifier();


            ProcessNotifications(email, "myemail@email.com", "Your order has been placed");

            ProcessNotifications(sms, "967345281", "Your OTP is 12");


            // Showing validation
            try
            {
                ProcessNotifications(email, " ", "Hii!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                ProcessNotifications(sms, "189298119", "");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
