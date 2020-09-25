using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings
{
    public static class IsPalindromes
    {
		public static bool IsPalindrome(string str)
		{
			int leftIdx = 0;
			int rightIdx = str.Length - 1;

			for (int i = 0; i < str.Length; i++)
			{
				if (str[leftIdx] != str[rightIdx])
				{
					return false;
				}

				leftIdx++;
				rightIdx--;
			}
			return true;
		}
	}
}

