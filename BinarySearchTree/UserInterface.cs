using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    static class UserInterface
    {
        public static int ValidateNumericResponse(string response)
        {
            bool isNumber;
            int number;
            do
            {
                isNumber = Int32.TryParse(response, out number);
                if (isNumber == false)
                {
                    Console.WriteLine("Not a valid number! Enter another number.");
                    response = Console.ReadLine();
                }
            }
            while (isNumber == false);
            return number;

        }

       public static int EnterNewValueForTree()
        {
            Console.Clear();
            Console.WriteLine("Enter an integer to add to the tree:");
            string response = Console.ReadLine();
            int value = ValidateNumericResponse(response);
            return value;
        }

        public static void ResultMessageForSearch(bool didFindValue)
        {
            if (didFindValue == true)
            {
                Console.WriteLine("Value found!");
            }
            else
            {
                Console.WriteLine("Value was not found in the tree.");
            }
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static int EnterValueToSearch()
        {
            Console.Clear();
            Console.WriteLine("Enter an integer to search for:");
            string response = Console.ReadLine();
            int value = ValidateNumericResponse(response);
            return value;
        }

        public static void SuccessMessageForAdd()
        {
            Console.WriteLine("Node placed! Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static int MainMenu(int numberOfLeaves)
        {
            Console.WriteLine($"Binary Search Tree: {numberOfLeaves} items to search");
            Console.WriteLine("(1) Add another item");
            Console.WriteLine("(2) Search for an item");
            Console.WriteLine("(3) Quit");
            int numberChoice;
            do
            {
                string response = Console.ReadLine();
                numberChoice = ValidateNumericResponse(response);
                if (numberChoice < 1 || numberChoice > 3)
                {
                    Console.WriteLine("Not a number on the list! Try again.");
                }
            }
            while (numberChoice < 1 || numberChoice > 3);
            return numberChoice;
        }
    }
}
