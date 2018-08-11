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
            UserInterface.ResultMessageForSearch(didFindValue);
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
                        SearchForEmptySpotInDirection(nodeToCheck.leftChild, nodeToPlace, "left");

                    }
                    else if (nodeToPlace.value >= nodeToCheck.value)
                    {
                        SearchForEmptySpotInDirection(nodeToCheck.rightChild, nodeToPlace, "right");
                    }
                }
            } 
        }

        private void SearchForEmptySpotInDirection(Node childInDirection, Node nodeToPlace, string direction)
        {
            if (childInDirection == null)
            {
                if (direction == "left")
                {
                    nodeToCheck.leftChild = nodeToPlace;
                }
                else if (direction == "right")
                {
                    nodeToCheck.rightChild = nodeToPlace;
                }
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
                wasFound = false;
                while (wasFound == false && nodeToCheck != null)
                {
                    if (value < nodeToCheck.value)
                    {
                        MoveToNextNodeToSearch(nodeToCheck.leftChild, "left", nodeToCheck.value);

                    }
                    else if (value > nodeToCheck.value)
                    {
                        MoveToNextNodeToSearch(nodeToCheck.rightChild, "right", nodeToCheck.value);
                    }
                    else if (value == nodeToCheck.value)
                    {
                        wasFound = true;
                    }
                }
            }
            return wasFound;

        }

        private void MoveToNextNodeToSearch(Node childInDirection, string direction, int originalValue)
        {
            if (childInDirection == null)
            {
                Console.WriteLine($"Went {direction} from {originalValue}, no value was present");
                nodeToCheck = null;
            }
            else
            {
                Console.WriteLine($"Went {direction} from {originalValue}, value was {childInDirection.value}");
                nodeToCheck = childInDirection;
            }
        }

        
        
      
    }
}
