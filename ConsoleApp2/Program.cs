using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread fibonacci = new Thread(Fibonacci);
            Thread prime = new Thread(Prime);

            fibonacci.Start();
            prime.Start();

            fibonacci.Join();
            foreach (int num in fibonacci_nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"{fibonacci_nums.Count} чисел Фiбоначчі");

            prime.Join();
            foreach (int num in primes)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"{primes.Count} простих чисел");

        }

        static List<int> fibonacci_nums = new List<int>();
        static List<int> primes = new List<int>();

        static void Fibonacci()
        {

        }
        static void Prime()
        {

        }
    }
}
