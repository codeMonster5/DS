using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public static class ValidateBsts
    {
		public static bool ValidateBst(BST tree)
		{
			// Write your code here.
			return ValidateBstHelper(tree, Int32.MinValue, Int32.MaxValue);
		}

		public static bool ValidateBstHelper(BST tree, int minValue, int maxValue)
		{
			if (tree.value < minValue || tree.value >= maxValue)
			{
				return false;
			}

			if (tree.left != null && !ValidateBstHelper(tree.left, minValue, tree.value))
			{
				return false;
			}

			if (tree.right != null && !ValidateBstHelper(tree.right, tree.value, maxValue))
			{
				return false;
			}
			return true;
		}



		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
			}
		}
	}
}
