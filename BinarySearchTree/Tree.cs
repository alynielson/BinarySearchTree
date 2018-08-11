using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node root;
        Node nodeToCheck;

        public Tree()
        {
            root = null;
        }

        private void AddNode(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                Node nodeToPlace = new Node(value);
                nodeToCheck = root;
                while (nodeToPlace.parent == null)
                {
                    if (nodeToPlace.value < nodeToCheck.value)
                    {
                        SearchForSpotInDirection(nodeToCheck.leftChild, nodeToPlace);

                    }
                    else if (nodeToPlace.value >= nodeToCheck.value)
                    {
                        SearchForSpotInDirection(nodeToCheck.rightChild, nodeToPlace);
                    }
                }
            } 
        }

        private void SearchForSpotInDirection(Node childInDirection, Node nodeToPlace)
        {
            if (childInDirection == null)
            {
                childInDirection = nodeToPlace;
                nodeToPlace.parent = nodeToCheck;
            }
            else
            {
                nodeToCheck = childInDirection;
            }
        }

        

        
        
      
    }
}
