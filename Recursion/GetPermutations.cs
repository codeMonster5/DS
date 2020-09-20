using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Recursion
{
    public static class GetPermutation
    {
			public static List<List<int>> GetPermutations(List<int> array)
			{
				List<List<int>> perms = new List<List<int>>();
				GetPermutations(array, new List<int>(), perms);
				return perms;
			}

			public static void GetPermutations(List<int> array, List<int> currentPermutation, List<List<int>> perms)
			{
				if (array.Count == 0 && currentPermutation.Count > 0)
				{
					perms.Add(currentPermutation);
				}

				else
				{
					for (int i = 0; i < array.Count; i++)
					{
						List<int> newArray = new List<int>(array);
						newArray.RemoveAt(i);
						List<int> newPermutation = new List<int>(currentPermutation);
						newPermutation.Add(array[i]);
						GetPermutations(newArray, newPermutation, perms);
					}
				}
			}
		}

	}

