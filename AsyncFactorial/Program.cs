using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncFactorial
{
    class Program
    {
        //Метод Counter для дополнительной нагрузки и демонстрации работы асинхронного метода CalculateFactorial
        
        static void Main(string[] args)
        {
            Console.Write("Введите число, для вычисления факториала (от 1 до 20): ");
            int number = Convert.ToInt32(Console.ReadLine());
            CalculateFactorialAsync(number);
            Counter();            
            Console.WriteLine("Конец работы метода Main");
            Console.ReadKey();
        }
        static void CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine($"Факториал числа {number}: {factorial}");
        }
        static async void CalculateFactorialAsync(int number)
        {
            Console.WriteLine("Начало работы асинхронного метода вычисления факториала");
            await Task.Run(() => CalculateFactorial(number));
            Console.WriteLine("Конец работы асинхронного метода вычисления факториала");
        }
        static void Counter()
        {
            Console.WriteLine("Начало работы метода Counter");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Работа метода Counter: {i}");
                Thread.Sleep(200);
            }
            Console.WriteLine("Конец работы метода Counter");
        }
    }
}
