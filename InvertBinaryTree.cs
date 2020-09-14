using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{

	public static class InvertBinaryTree
	{
		public static void InvertBinaryTrees(BinaryTree tree)
		{
			if (tree == null)
			{
				return;
			}
			Swap(tree);
			InvertBinaryTrees(tree.left);
			InvertBinaryTrees(tree.right);
		}

		public static void Swap(BinaryTree root)
		{
			BinaryTree left = root.left;
			root.left = root.right;
			root.right = left;
		}

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}
	}
}

