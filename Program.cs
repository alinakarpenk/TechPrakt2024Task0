using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введіть друге число:");
            string num2 = Console.ReadLine();
            double sum = double.Parse(num1) + double.Parse(num2);
            Console.WriteLine($"Сума чисел: {sum}");
            Console.ReadKey();

        }
    }
}
