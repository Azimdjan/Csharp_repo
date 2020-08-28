using System;
using System.ComponentModel.Design;

namespace Project10
{
    class Program
    {
        private static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine("1. New Game.");
            Console.WriteLine("2. Load Game.");
            Console.WriteLine("3. Options.");
            Console.WriteLine("4. Quit.");
        }
        static void Main(string[] args)
        {
            Menu();
            int choice = int.Parse(Console.ReadLine());
            while(choice!=4)
            {
                Console.WriteLine("Do you really want to continue if yes press 1 otherwise 2");
                int want = int.Parse(Console.ReadLine());
                while (want == 1)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("New game was started!");
                            break;
                        case 2:
                            Console.WriteLine("Load game...");
                            break;
                        case 3:
                            Console.WriteLine("Option screen");
                            break;
                        case 4:
                            break;
                    }
                    Console.WriteLine("Do you really want to continue if yes press 1 otherwise 2");
                    want = int.Parse(Console.ReadLine());
                }
                Menu();
                choice = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
}
