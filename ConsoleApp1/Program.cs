using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++ )
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Out.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Out.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Out.WriteLine("Buzz");
                }
                else
                {
                    Console.Out.WriteLine(i);
                }
            }
        }
    }
}