using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    

   public static class NodeDepth
	{
			public static int NodeDepths(BinaryTree root)
			{

				return NodeDepthHelper(root, 0);

				return -1;
			}

			public static int NodeDepthHelper(BinaryTree root, int depth)
			{
				if (root == null)
				{
					return 0;
				}

				return depth + NodeDepthHelper(root.left, depth + 1) + NodeDepthHelper(root.right, depth + 1);
			}

			public class BinaryTree
			{
				public int value;
				public BinaryTree left;
				public BinaryTree right;

				public BinaryTree(int value)
				{
					this.value = value;
					left = null;
					right = null;
				}
			}
		}

	
}
