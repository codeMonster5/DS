using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings
{
    public static class HasSingleCycles
    {
		public static bool HasSingleCycle(int[] array)
		{
			int numberElementsVisited = 0;
			int currentIdx = 0;
			while (numberElementsVisited < array.Length)
			{
				if (numberElementsVisited > 0 && currentIdx == 0)
				{
					return false;
				}
				numberElementsVisited++;
				currentIdx = getNextIdx(currentIdx, array);
			}
			return currentIdx == 0;
		}

		public static int getNextIdx(int currentIdx, int[] array)
		{
			int jump = array[currentIdx];
			int nextIdx = (currentIdx + jump) % array.Length;
			return nextIdx >= 0 ? nextIdx : nextIdx + array.Length;
		}
	}
}
