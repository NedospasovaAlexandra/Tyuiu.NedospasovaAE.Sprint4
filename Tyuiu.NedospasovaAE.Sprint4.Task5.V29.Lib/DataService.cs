using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedospasovaAE.Sprint4.Task5.V29.Lib
{
    public class DataService : ISprint4Task5V29
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
