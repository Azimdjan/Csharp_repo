using System;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter degree: ");
            float degree = float.Parse(Console.ReadLine());
            float cosine = (float)Math.Cos(degree * Math.PI / 180);
            Console.WriteLine("Cosine of " + degree + " is " + cosine);
            float sinus = (float)Math.Sin(degree * Math.PI / 180);
            Console.WriteLine("Sinus of " + degree + " is " + sinus);
            Console.WriteLine();
        }
    }
}
