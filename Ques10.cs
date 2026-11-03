using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    class AuditEvent
    {
        public int EventId { get; }
        public string Description { get; }
        public DateTime Time {  get; }

        public AuditEvent(int eventId, string description, DateTime time) { 
            EventId = eventId; 
            Description = description; 
            Time = time; 
        }

        
        public override string ToString()
        {
            return $"Event ID: {EventId}, Description: {Description}, Time: {Time}";
        }
    }
    public class Ques10
    {
        public static void Run()
        {
            AuditEvent event1 = new AuditEvent(102, "User logged in", new DateTime(2026, 11, 3, 9, 30, 0));

            // Same object, different reference variable
            AuditEvent eventAlias = event1;

            // Seperate object with identical values
            AuditEvent event2 = new AuditEvent(102, "User logged in", new DateTime(2026, 11, 3, 9, 30, 0));

            // Array can store values of different types
            object[] auditItems =
            {
                500,
                2499.50m,
                "Login Successful",
                new DateTime(2026, 11, 3),
                event1
            };

            Console.WriteLine("Audit Event Viewer");

            foreach(object item in auditItems)
            {
                Console.WriteLine($"Value: {item}");
                Console.WriteLine($"Runtime Type: {item.GetType().Name}");
                Console.WriteLine("----");
            }

            Console.WriteLine("Reference Comparision");

            Console.WriteLine("event1==eventAlias"+(event1==eventAlias));
            Console.WriteLine("event1.Equals(eventAlias)" + (event1.Equals(eventAlias)));
            Console.WriteLine("event1==event2" + (event1 == event2));
            Console.WriteLine("event1.Equals(eventAlias)" + (event1.Equals(eventAlias)));

        }
    }
}
