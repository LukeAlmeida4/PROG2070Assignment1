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
            int currentLength;
            int currentWidth;

            Console.WriteLine("Enter a positive value for the rectangle length");
            userChoice = GetInput();
            currentLength = Rectangle.SetLength(userChoice);

            Console.WriteLine("Enter a positive value for the rectangle Width");
            userChoice = GetInput();
            currentWidth = Rectangle.SetWidth(userChoice);


            while (userChoice != 7)
            {
                userChoice = Menu();

                if (userChoice == 7)
                {
                    return;
                }
                //

                if (userChoice == 1)
                {
                    Console.WriteLine("The current length of the rectangle is:" + currentLength.ToString());
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Please input the new length for the rectangle");
                    userChoice = GetInput();
                    currentLength = Rectangle.SetLength(userChoice);
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("The current width of the rectangle is:" + currentWidth.ToString());

                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Please input the new width for the rectangle");
                    userChoice = GetInput();
                    currentLength = Rectangle.SetWidth(userChoice);
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("The current perimeter of the rectangle is: " + Rectangle.GetPerimeter());

                }
                else if (userChoice == 6)
                {
                    Console.WriteLine("The current area of the rectangle is: " + Rectangle.GetArea());

                }
                else
                {
                    return;
                }
            }
        }

        public static int GetInput()
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
