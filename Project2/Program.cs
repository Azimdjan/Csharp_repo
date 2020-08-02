using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first location: ");
            int firstAltitude = int.Parse(Console.ReadLine());
            Console.Write("Please enter second location: ");
            int secondAltitude = int.Parse(Console.ReadLine());
            int difference = 0;
            if(firstAltitude>secondAltitude)
            {
                difference = firstAltitude - secondAltitude;
            }
            else
            {
                difference = secondAltitude - firstAltitude;
            }
            Console.WriteLine("Difference between locations is: " + difference + " km");
            Console.WriteLine();
        }
    }
}
