using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число для проверки: ");
            double digit = double.Parse(Console.ReadLine());
            double i = 1;
            double sum = 0;
            bool condition = false;
            while (i<digit-1)
            {
                i++;
                sum = digit % i;
                if (sum == 0)
                {
                    condition = true;
                                        
                }
               
            }
            if (condition)
            {
                Console.WriteLine("число не является простым");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
                        
            
            Console.ReadKey();
        }
    }
}
