using System;
using System.Collections.Generic;

namespace Project8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i+1);
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            for(int i=numbers.Count;i>0;i--)
            {
                if (i % 2 == 0)
                    numbers.Remove(i);
            }

            for (int i= 0;i < numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
