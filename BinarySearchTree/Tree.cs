using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node node;
        Node root;
        int height;
        Node nodeToCheck;


        public Tree()
        {
            height = 0;
        }

       

        private void AddNode(int value)
        {
            if (height == 0)
            {
                root = new Node(value);
                node.level = 0;
                nodeToCheck = root; 
            }
           
        }

        private void CompareNodes(Node node)
        {
            while (node.parent == null)
            {
                if (node.value < nodeToCheck.value)
                {
                    if (nodeToCheck.leftChild == null)
                    {
                        nodeToCheck.leftChild = node;
                        node.parent = nodeToCheck;
                        node.level = node.parent.level + 1;
                    }
                    else
                    {
                        nodeToCheck = nodeToCheck.leftChild;
                    }

                }
                else if (node.value >= nodeToCheck.value)
                {
                    if (nodeToCheck.rightChild == null)
                    {
                        nodeToCheck.rightChild = node;
                        node.parent = nodeToCheck;
                        node.level = node.parent.level + 1;
                    }
                    else
                    {
                        nodeToCheck = nodeToCheck.rightChild;
                    }
                }
               
            }
        }

        

        
        
      
    }
}
