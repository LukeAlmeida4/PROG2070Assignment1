using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment1
{
    class Program
    {
        public static void Main()
        {
            int userChoice = 0;
            int numberChoice = 0;

            while (userChoice != 7)
            {
                userChoice = Menu();

                if (userChoice == 7)
                {
                    return;
                }
                //
                //Console.WriteLine("Select either 1 - 7");
                //numberChoice = GetChoice();

                if (userChoice == 1)
                {
                    Console.WriteLine("This works!!");
                    //run method
                }
                else if (userChoice == 2)
                {

                }
                else if (userChoice == 3)
                {

                }
                else if (userChoice == 4)
                {

                }
                else if (userChoice == 5)
                {

                }
                else if (userChoice == 6)
                {

                }
                else
                {
                    return;
                }
            }
        }

        private static int GetLength()
        {
            try
            {
                int choice = int.Parse(Console.ReadLine());
                return choice;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number between 1 and 7");
                return 0;
            }
        }
        private static int Menu()
        {
            int optionChoice;

            Console.WriteLine("Rectangle Manipulator");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Get Rectable Length");
            Console.WriteLine("2. Changle Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
            try
            {
                optionChoice = int.Parse(Console.ReadLine());
            }
            catch
            {
                optionChoice = 0;
            }

            return optionChoice;
        }
    }
}
