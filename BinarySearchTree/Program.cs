using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tree tree = new Tree();
            bool isStillUsingTree = true;
            do
            {

                int action = UserInterface.MainMenu(tree.numberOfLeaves);
                if (action == 1)
                {
                    tree.AddNode();
                }
                else if (action == 2)
                {
                    tree.SearchForNode();
                }
                else if (action == 3)
                {
                    isStillUsingTree = false;
                }
            }
            while (isStillUsingTree == true);
        }

        
    }
}
