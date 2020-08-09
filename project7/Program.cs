using System;

namespace project7
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Welcome to my new Console Game!");
            Console.WriteLine();
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("1 - NewGame.");
            Console.WriteLine("2 - LoadGame.");
            Console.WriteLine("3 - Options.");
            Console.WriteLine("4 - Quit.");
            Console.WriteLine();
            Console.WriteLine("Please enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("New Game was started!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Load Game was started!");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Options was started!");
            }
            else if(choice==4)
            {
                Console.WriteLine("Quit!");
            }
            else
            {
                Console.WriteLine("Wrong input was entered!");
            }

            Console.WriteLine("Welcome to my new Console Game!");
            Console.WriteLine();
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("1 - NewGame.");
            Console.WriteLine("2 - LoadGame.");
            Console.WriteLine("3 - Options.");
            Console.WriteLine("4 - Quit.");
            Console.WriteLine();
            Console.WriteLine("Please enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("New Game was started!");
                    break;
                case 2:
                    Console.WriteLine("Load game was started!");
                    break;
                case 3:
                    Console.WriteLine("Options was started!");
                    break;
                case 4:
                    Console.WriteLine("Quit!");
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }

        }
    }
}
