using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public static class SameBst
    {
		public static bool SameBsts(List<int> arrayOne, List<int> arrayTwo)
		{

			return SameBstHelper(arrayOne, arrayTwo);
		}
		public static bool SameBstHelper(List<int> arrayOne, List<int> arrayTwo)
		{
			if (arrayOne.Count != arrayTwo.Count) return false;

			if (arrayOne.Count == 0 && arrayTwo.Count == 0)
			{
				return true;
			}

			if (arrayOne[0] != arrayTwo[0])
			{
				return false;
			}

			List<int> leftOne = getSmaller(arrayOne);
			List<int> leftTwo = getSmaller(arrayTwo);
			List<int> rightOne = getBiggerOrEqual(arrayOne);
			List<int> rightTwo = getBiggerOrEqual(arrayTwo);

			return SameBstHelper(leftOne, leftTwo) && SameBstHelper(rightOne, rightTwo);

		}

		public static List<int> getSmaller(List<int> array)
		{
			List<int> smaller = new List<int>();

			for (int i = 1; i < array.Count; i++)
			{
				if (array[i] < array[0]) smaller.Add(array[i]);
			}

			return smaller;

		}

		public static List<int> getBiggerOrEqual(List<int> array)
		{
			List<int> biggerOrEqual = new List<int>();

			for (int i = 1; i < array.Count; i++)
			{
				if (array[i] >= array[0]) biggerOrEqual.Add(array[i]);
			}

			return biggerOrEqual;
		}

	}

}

