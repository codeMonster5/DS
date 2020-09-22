using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings
{
    public static class LongestSubstringWithoutDuplications
    {
		public static string LongestSubstringWithoutDuplication(string str)
		{
			// Write your code here
			Dictionary<char, int> lastSeen = new Dictionary<char, int>();

			int[] longest = new int[] { 1, 0 };

			int startIndex = 0;

			for (int i = 0; i < str.Length; i++)
			{
				var c = str[i];
				if (lastSeen.ContainsKey(c))
				{
					startIndex = Math.Max(startIndex, lastSeen[c] + 1);
				}

				if (longest[1] - longest[0] < i + 1 - startIndex)
				{
					longest = new int[] { startIndex, i + 1 };
				}

				lastSeen[c] = i;
			}

			string result = str.Substring(longest[0], longest[1] - longest[0]);

			return result;
		}
	}
}
