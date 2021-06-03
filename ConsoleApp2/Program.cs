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
            int a, b, c = 1;
            fibonacci_nums.Add(b = 0);
            do
            {
                fibonacci_nums.Add(c);
                a = b;
                b = c;
                c = a + b;
            } while (c > 0);
        }
        static void Prime()
        {
            int MaxF = 1000;
            int N = 7;
            if (N % 3 == 0)
            {
                Console.WriteLine("Шукай далі");
                return;
            }

            int[] a = new int[MaxF];
            for (int i = 2; i < MaxF; i++)
                if (a[i] == 0)
                {
                    if (i > N && (i - N) % 3 == 0)
                    {
                        // Найшли
                        Console.WriteLine(i);
                        break;
                    }
                    for (int j = i + i; j < MaxF; j += i)
                        a[j] = 1;
                }
        }
    }
}


 