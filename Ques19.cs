using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    class Registration
    {
        // static variable: shared by every reg obj
        private static int _regCount = 0;

        // Instance prop: each object has its own values
        public int RegId { get; }
        public string LearnerName { get; set; }
        public string BatchName { get; }

        // Static prop to access shared counter
        public static int RegCount
        {
            get { return _regCount; }
        }

        public Registration(string learnerName, string batchName)
        {
            if (string.IsNullOrWhiteSpace(learnerName))
                throw new ArgumentException("Leaner name cannot be empty");
            if (string.IsNullOrWhiteSpace(batchName))
                throw new ArgumentException("Batch name cannot be empty");

            _regCount++;

            RegId = _regCount;
            LearnerName = learnerName;
            BatchName = batchName;
        }
        public void Display(string label)
        {
            Console.WriteLine(label);
            Console.WriteLine($"Registration Id : {RegId}");
            Console.WriteLine($"Learner name : {LearnerName}");
            Console.WriteLine($"Batch Name : {BatchName}");

        }
    }
    public class Ques19
    {
        public static void Run()
        {
            
            Registration reg1 = new Registration("Aarav", "C# Batch A");
            Registration reg2 = new Registration("Diya", "C# Batch A");

            Registration reg3 = new Registration("Kabir", "C# Batch A");

        }
    }
}
