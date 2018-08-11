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
        public int numberOfLeaves;

        public Tree()
        {
            root = null;
            numberOfLeaves = 0;
        }

        public void AddNode()
        {
            int value = UserInterface.EnterNewValueForTree();
            PlaceNewNode(value);
            UserInterface.SuccessMessageForAdd();
        }

        public void SearchForNode()
        {
            int value = UserInterface.EnterValueToSearch();
            bool didFindValue = FindNode(value);
            if (didFindValue == true)
            {

            }
            else
            {

            }
        }

        private void PlaceNewNode(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                numberOfLeaves++;
            }
            else
            {
                Node nodeToPlace = new Node(value);
                nodeToCheck = root;
                while (nodeToPlace.parent == null)
                {
                    if (nodeToPlace.value < nodeToCheck.value)
                    {
                        SearchForEmptySpotInDirection(nodeToCheck.leftChild, nodeToPlace);

                    }
                    else if (nodeToPlace.value >= nodeToCheck.value)
                    {
                        SearchForEmptySpotInDirection(nodeToCheck.rightChild, nodeToPlace);
                    }
                }
            } 
        }

        private void SearchForEmptySpotInDirection(Node childInDirection, Node nodeToPlace)
        {
            if (childInDirection == null)
            {
                childInDirection = nodeToPlace;
                nodeToPlace.parent = nodeToCheck;
                numberOfLeaves++;
            }
            else
            {
                nodeToCheck = childInDirection;
            }
        }

        private bool FindNode(int value)
        {
            bool wasFound;
            if (root == null)
            {
                wasFound = false;
            }
            else
            {
                nodeToCheck = root;
                while (wasFound = false && nodeToCheck != null)
                {
                    if (value < nodeToCheck.value)
                    {
                        MoveToNextNodeToSearch(nodeToCheck.leftChild, "left");

                    }
                    else if (value > nodeToCheck.value)
                    {
                        MoveToNextNodeToSearch(nodeToCheck.rightChild, "right");
                    }
                    else if (value == nodeToCheck.value)
                    {
                        wasFound = true;
                    }
                }
            }
            return wasFound;

        }

        private void MoveToNextNodeToSearch(Node childInDirection, string direction)
        {
            Console.WriteLine($"Went {direction}, value was {childInDirection.value}");
            nodeToCheck = childInDirection;
        }

        
        
      
    }
}
