using System;

namespace DataStructure
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FlattenBinaryTree.BinaryTree tree = new FlattenBinaryTree.BinaryTree(4);
            tree.left = new FlattenBinaryTree.BinaryTree(6);
            tree.left.left = new FlattenBinaryTree.BinaryTree(7);
            tree.left.right = new FlattenBinaryTree.BinaryTree(8);
            tree.right = new FlattenBinaryTree.BinaryTree(9);
            tree.right.left = new FlattenBinaryTree.BinaryTree(14);
            tree.right.right = new FlattenBinaryTree.BinaryTree(16);

            var value = FlattenBinaryTree.FlattenBinaryTrees(tree);

            while(value.right != null)
            {
                Console.WriteLine(value.right.value);

                value.right = value.right.right;
            }

            //Console.Write(value);

            Console.ReadLine();
        }
    }
}