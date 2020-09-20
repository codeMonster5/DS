using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Recursion
{
	public static class Powerset
    {
		public static List<List<int>> Powersets(List<int> array)
		{
				List<List<int>> subsets = new List<List<int>>();
				subsets.Add(new List<int>());

				foreach (int ele in array)
				{
					int length = subsets.Count;

					for (int i = 0; i < length; i++)
					{
						List<int> currentSubset = new List<int>(subsets[i]);
						currentSubset.Add(ele);
						subsets.Add(currentSubset);
					}

				}
			return subsets;
		}
	}
}
