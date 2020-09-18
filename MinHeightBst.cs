using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public static class  MinHeightBsts
    {
       

		public static BST MinHeightBst(List<int> array)
		{
			return CalculateminHeightBstHelper(array, 0, array.Count - 1, null);
		}

		public static BST CalculateminHeightBstHelper(List<int> array, int startIndex, int endIndex, BST bst)
		{
			if (endIndex < startIndex)
			{
				return null;
			}

			int midIndex = (startIndex + endIndex) / 2;
			int addValue = array[midIndex];
			if (bst == null)
			{
				bst = new BST(addValue);

			}
			else
			{
				bst.insert(addValue);
			}

			CalculateminHeightBstHelper(array, startIndex, midIndex - 1, bst);

			CalculateminHeightBstHelper(array, midIndex + 1, endIndex, bst);

			return bst;
		}



		public class BST
		{
			public int value;
			public BST left;
			public BST right;

			public BST(int value)
			{
				this.value = value;
				left = null;
				right = null;
			}

			public void insert(int value)
			{
				if (value < this.value)
				{
					if (left == null)
					{
						left = new BST(value);
					}
					else
					{
						left.insert(value);
					}
				}
				else
				{
					if (right == null)
					{
						right = new BST(value);
					}
					else
					{
						right.insert(value);
					}
				}
			}
		}
	}
}


