using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Que3
    {
        public static void Run()
        {
            // 1 and 2.
            decimal[,] sales = { { 12000, 9000, 5000, 7000}, { 8000, 11000, 6000, 9500 }, { 15000, 7000, 8500, 4000 } };

            // 3. Total for each branch and each category

            decimal[] branchTotal = {0}, catTotal = {0};
            int rows = sales.GetLength(0), cols = sales.GetLength(1);
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0; j < cols; j++) {
                    branchTotal[i] += sales[i, j];
                    catTotal[j] += sales[i, j];
                }
            }

            // branch with the highest total :
            decimal branch_max = sales[0,0];
            int branch = 0;
            for (int i = 0; i < rows; i++)
            {
                if(branch_max < branchTotal[i])
                {
                    branch_max = branchTotal[i];
                    branch = i+1;
                }
            }

            // 4.

        }
    }
}
