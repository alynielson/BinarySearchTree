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
                }
            }
            while (isNumber == false);
            Console.Clear();
            return number;

        }

       
    }
}
