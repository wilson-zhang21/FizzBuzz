using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Please enter the max number");
            int max = Convert.ToInt32(Console.In.ReadLine());
            
            
            
            for(int i = 1; i <= max; i++ )
            {
                List<string> result = new List<string>();
                if (i % 3 == 0 )
                {
                    result.Add("Fizz");
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }

                if (i % 7 == 0)
                {
                    result.Add("Bang");
                }

                if (i % 11 == 0)
                {
                    result.Add("Bong");
                }

                if (i % 13 == 0)
                {
                    int firstB = result.FindIndex(a => a.StartsWith("B"));
                    if (firstB >= 0)
                    {
                        result.Insert(firstB, "Fezz");
                    }
                    else
                    {
                        result.Add("Fezz");
                    }
                }

                if (i % 17 == 0)
                {
                    result.Reverse();
                }


                if (result.Any())
                {
                    Console.Out.WriteLine(string.Join("",result));
                }
                else
                {
                    Console.Out.WriteLine(i);
                }
            }
        }
    }
}