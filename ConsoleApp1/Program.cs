using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//task 8

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double divident, divider, result;

            Console.WriteLine("Нахождение частного чисел\nВведите сначала делимое, а затем делитель(не равный нулю)");
            try
            {
                divident = Convert.ToDouble(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Неверный формат ввода (делимое)");
                Console.ReadLine();
                return;
            }

            try
            {
                divider = Convert.ToDouble(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Неверный формат ввода (делитель)");
                Console.ReadLine();
                return;
            }

            if (divider == 0) Console.WriteLine("Нельзя делить на 0");
            else
            {
                result = divident / divider;
                Console.WriteLine(divident + " / " + divider + " = " + result);
            }

            Console.ReadLine();
        }
    }
}
