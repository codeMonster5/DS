using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public static class findRightSibling
    {
        // A Binary Tree Node 
        public  class Node
        {
            public int data;
            public Node left, right, parent;

            // Constructor 
            public Node(int data, Node parent)
            {
                this.data = data;
                left = null;
                right = null;
                this.parent = parent;
            }
        }

        // Method to find right sibling 
        public static Node findRightSiblings(Node node, int level)
        {
            if (node == null || node.parent == null)
            {
                return null;
            }

          
            while (node.parent.right == node
                   || (node.parent.right == null
                       && node.parent.left == node))
            {
                if (node.parent == null
                    || node.parent.parent == null)
                {
                    return null;
                }

                node = node.parent;
                level--;
            }

            // Move to the required child, where right sibling 
            // can be present 
            node = node.parent.right;

            // find right sibling in the given subtree(from current 
            // node), when level will be 0 
            while (level < 0)
            {

                // Iterate through subtree 
                if (node.left != null)
                {
                    node = node.left;
                }
                else if (node.right != null)
                {
                    node = node.right;
                }
                else
                {

                    // if no child are there, we cannot have right 
                    // sibling in this path 
                    break;
                }

                level++;
            }

            if (level == 0)
            {
                return node;
            }

         
            return findRightSiblings(node, level);
        }
    }
}
