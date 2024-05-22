using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedospasovaAE.Sprint4.Task3.V21.Lib
{
    public class DataService : ISprint4Task3V21
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int result = 1;
            for (int i = 0; i < rows; i++)
            {
                result *= array[i, columns - 1];
            }
            return result;
        }
    }
}
