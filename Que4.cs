using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Que4
    {
        public static void Run()
        {
            int[][] tech = new int[4][];

            tech[0] = [45, 60, 30];
            tech[1] = [90];
            tech[2] = [];
            tech[3] = [20, 35, 50, 40];

            int total = 0;
            for (int i = 0; i < tech.Length; i++)
            {
                total = 0;
                for(int j = 0; j < tech[i].Length; j++)
                {
                    total += tech[i][j];
                }
                if(tech[i].Length==0)
                {
                    Console.WriteLine($"The technician {i + 1} has no work");
                }
                else 
                    Console.WriteLine($"Technician {i + 1}'s job count is {tech[i].Length} and Total assigned minutes {total}");
                
                if(total>120)
                {
                    Console.WriteLine($"The technician {i + 1} assigned more than 120 minutes");
                }
            }
            tech[2][0] = 22;
        }
    }
}
