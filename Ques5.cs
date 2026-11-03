using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    class Employeee
    {
        public string Name { get; }

        // Nullable value types
        public int? Age { get; private set; }
        public decimal? BonusAmount { get; private set; }
        public DateTime? JoiningDate { get; private set; }

        public Employeee(string name, int? age, decimal? bonusAmount, DateTime? joiningDate)
        {
            Name = name;
            Age = age;
            BonusAmount = bonusAmount;
            JoiningDate = joiningDate;
        }
    }
    public class Ques5
    {
        static void Run()
        {

        }

    }
}
