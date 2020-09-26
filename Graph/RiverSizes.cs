using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Graph
{
    public static class RiverSize
    {
		public static List<int> RiverSizes(int[,] matrix)
		{
			bool[,] Visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
			List<int> sizes = new List<int>();

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (Visited[i, j])
					{
						continue;
					}

					traverseNode(i, j, matrix, Visited, sizes);
				}
			}

			return sizes;
		}

		public static void traverseNode(int i, int j, int[,] matrix, bool[,] Visited, List<int> sizes)
		{
			int currentRiverSize = 0;
			Stack<int[]> nodePushToStack = new Stack<int[]>();
			nodePushToStack.Push(new int[] { i, j });

			while (nodePushToStack.Count != 0)
			{
				int[] currentNode = nodePushToStack.Pop();
				i = currentNode[0];
				j = currentNode[1];

				if (Visited[i, j])
				{
					continue;
				}
				Visited[i, j] = true;

				if (matrix[i, j] == 0)
				{
					continue;
				}
				currentRiverSize++;
				List<int[]> unvisitedNodes = getUnvisitedNodes(i, j, matrix, Visited);

				foreach (var neighborNode in unvisitedNodes)
				{
					nodePushToStack.Push(neighborNode);
				}
			}

			if (currentRiverSize > 0)
			{
				sizes.Add(currentRiverSize);
			}
		}

		public static List<int[]> getUnvisitedNodes(int i, int j, int[,] matrix, bool[,] Visited)
		{
			List<int[]> unvisitedneighbor = new List<int[]>();
			if (i > 0 && !Visited[i - 1, j])
			{
				unvisitedneighbor.Add(new int[] { i - 1, j });
			}

			if (i < matrix.GetLength(0) - 1 && !Visited[i + 1, j])
			{
				unvisitedneighbor.Add(new int[] { i + 1, j });
			}

			if (j > 0 && !Visited[i, j - 1])
			{
				unvisitedneighbor.Add(new int[] { i, j - 1 });
			}

			if (j < matrix.GetLength(1) - 1 && !Visited[i, j + 1])
			{
				unvisitedneighbor.Add(new int[] { i, j + 1 });
			}

			return unvisitedneighbor;
		}
	}
}
