using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            for(int i = 1; i <= 100; i++ )
            {
                string res = "";
                if (i % 3 == 0 )
                {
                    res = res + "Fizz";
                }
                if (i % 5 == 0)
                {
                    res = res + "Buzz";
                }
                
                if (res == "")
                {
                    Console.Out.WriteLine(i);
                }
                else
                {
                    Console.Out.WriteLine(res);
                }
            }
        }
    }
}