using System;
using System.Collections.Generic;

namespace DataStructure
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            RightSiblingTrees.BinaryTree tree = new RightSiblingTrees.BinaryTree(4);
            tree.left = new RightSiblingTrees.BinaryTree(6);
            tree.left.left = new RightSiblingTrees.BinaryTree(7);
            tree.left.right = new RightSiblingTrees.BinaryTree(8);
            tree.right = new RightSiblingTrees.BinaryTree(9);
            tree.right.left = new RightSiblingTrees.BinaryTree(14);
            tree.right.right = new RightSiblingTrees.BinaryTree(16);

           var value = RightSiblingTrees.RightSiblingTree(tree);

            while (value.right != null)
            {
               // Console.WriteLine(value.right.value);

                value.right = value.right.right;
            }

            findRightSibling.Node root = new findRightSibling.Node(1, null);
            root.left = new findRightSibling.Node(2, root);
            root.right = new findRightSibling.Node(3, root);
            root.left.left = new findRightSibling.Node(4, root.left);
            root.left.right = new findRightSibling.Node(6, root.left);
            root.left.left.left = new findRightSibling.Node(7, root.left.left);
            root.left.left.left.left = new findRightSibling.Node(10, root.left.left.left);
            root.left.right.right = new findRightSibling.Node(9, root.left.right);
            root.right.right = new findRightSibling.Node(5, root.right);
            root.right.right.right = new findRightSibling.Node(8, root.right.right);
            root.right.right.right.right = new findRightSibling.Node(12, root.right.right.right);

            // passing 10 
            // Console.WriteLine(findRightSibling.findRightSiblings(root.left.left.left, 0).data);

            //Console.Write(value);
            //powerset

           Console.WriteLine(Recursion.Powerset.Powersets(new List<int> { 1, 2, 3 }));

            Console.ReadLine();
        }
    }
}