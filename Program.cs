using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =1; i<=255; i++) 
            {
               //Console.WriteLine(i);
            }
            for (int num=1; num<=100; num++)
            {
                if (num % 3 ==0 || num % 5 == 0)
                {
                    if (!(num%3 == 0 && num%5 ==0))
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            for (int num=1;num<=100;num++)
            {
                if (num%3==0 && num%5 == 0)
                {
                    Console.WriteLine("FizzzBuzz");
                }
                if (!(num % 3 ==0 && num% 5 ==0))
                {
                    if (num%3 ==0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    if (num%5 ==0)
                    {
                        Console.WriteLine("Buzz");
                    }

                }
            }
        }
    }
}
