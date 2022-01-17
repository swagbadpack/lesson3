using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Приветствуем, сколько у вас карт? ");
            int quantityCard = int.Parse(Console.ReadLine());
            Console.WriteLine("Поочередно введите свои карты,  ");
            int sum = 0;
            int intSummand = 0;
            string strSummand = "card";
            for (int i = 0; i < quantityCard; i++)
            {
                Console.WriteLine("Введите номинал карты: ");
                strSummand = Console.ReadLine();
                if (strSummand == "J")
                {
                    intSummand = 10;
                }
                else if (strSummand == "Q")
                {
                    intSummand = 10;
                }
                else if (strSummand == "K")
                {
                    intSummand = 10;
                }
                else if (strSummand == "T")
                {
                    intSummand = 10;
                }
                else
                {
                    intSummand = Convert.ToInt32(strSummand);
                }
                switch (intSummand)
                {
                    case 6: sum = sum + 6;break;
                    case 7: sum = sum + 7;break;
                    case 8: sum = sum + 8;break;
                    case 9: sum = sum + 9;break;
                    case 10: sum = sum + 10;break;

                    default: Console.WriteLine("Введена неизвестная карта");break;
                }
            }


            Console.WriteLine($"Сумма: {sum}");

            Console.ReadKey();
        }

    }
}
