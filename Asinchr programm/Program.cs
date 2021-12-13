using System;
using System.Threading.Tasks;
namespace Asinchr_programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            uint d = Convert.ToUInt32(Console.ReadLine());
            uint r = FactorialAsync(d).Result;
            Console.WriteLine($"Факториал натурального числа {d} равен {r}");
            Console.ReadKey();
        }

        public static uint Factorial(uint n)
        {
               uint fact=1;
               for (uint i = 1;  i < n + 1 ; i++)
                {
                fact = fact * i;
                }
              return fact;

        }
        public static async Task<uint> FactorialAsync(uint n)
        {
            uint result = await Task<uint>.Run(() => Factorial(n));
            return result;
        }

    }
}
