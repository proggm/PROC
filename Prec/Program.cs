using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите необходимое вам число: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите необходимый вам процент: ");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вывод: " + Percent(first, second));

            Console.ReadKey();

        }
        public static double Percent(double one, double two)
        {
            return (one * two) / 100;
        }
    }
}
