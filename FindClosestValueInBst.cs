using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{

	public class FindClosestValueInBsts
	{
		public static int FindClosestValueInBst(BST tree, int target)
		{
			// Write your code here.
			return FindClosestValue(tree, target, tree.value);
		}

		public static int FindClosestValue(BST tree, int target, int closest)
		{
			if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
			{
				closest = tree.value;
			}

			if (target < tree.value && tree.left != null)
			{
				return FindClosestValue(tree.left, target, closest);
			}
			else if (target > tree.value && tree.right != null)
			{
				return FindClosestValue(tree.right, target, closest);
			}
			else
			{
				return closest;
			}
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
