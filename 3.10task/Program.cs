using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");         // вывод обЪяснения 
            int digit = int.Parse(Console.ReadLine());          // ввод с клавиатуры
            int outcome = digit % 2;                            // выделение остатка
            if (outcome == 0)                                   // ветвление
            {
                Console.WriteLine($"Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            Console.ReadKey();
        }

    }
}
