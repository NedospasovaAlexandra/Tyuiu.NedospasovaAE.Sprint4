using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint4.Task6.V12.Lib;

namespace Tyuiu.NedospasovaAE.Sprint4.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных 'Россия', 'Украина', 'Беларусь',            *");
            Console.WriteLine("* 'Казахстан', 'Молдова', 'Латвия', 'Эстони', используя класс Array,      *");
            Console.WriteLine("* выведите элементы массива, длина которых равна 7 символам.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var array = new string[] {"Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония"};
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Элементы массива, длина которых меньше 7 символов: ");
            string[] mas = ds.Calculate(array);
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
