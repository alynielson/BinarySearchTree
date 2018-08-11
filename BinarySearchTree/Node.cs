using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public Node leftChild;
        public Node rightChild;
        public Node parent;

        
        public int value;


        public Node(int value)
        {
            this.value = value;
            parent = null;
            leftChild = null;
            rightChild = null;
        }

       
        
    }
}
