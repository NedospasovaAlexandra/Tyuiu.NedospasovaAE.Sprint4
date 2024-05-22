using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint4.Task1.V8.Lib;

namespace Tyuiu.NedospasovaAE.Sprint4.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов массива c клавиатуры: 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] numsArray = new int[12];
            Console.WriteLine("Введите 12 целых чисел от 2 до 9:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Дан массив: ");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Ответ: " + ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
