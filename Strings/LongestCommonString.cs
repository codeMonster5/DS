﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings
{
    public static class LongestCommonString
    {
		// A Utility Function to find 
		// the common prefix between 
		// strings- str1 and str2 
	 public	static string commonPrefixUtil(string str1,
									string str2)
		{
			string result = "";
			int n1 = str1.Length,
				n2 = str2.Length;

			// Compare str1 and str2 
			for (int i = 0, j = 0;
					i <= n1 - 1 && j <= n2 - 1;
					i++, j++)
			{
				if (str1[i] != str2[j])
				{
					break;
				}
				result += str1[i];
			}

			return (result);
		}

		// A Function that returns the longest 
		// common prefix from the array of strings 
	 public	static string commonPrefix(string[] arr, int n)
		{
			string prefix = arr[0];

			for (int i = 1; i <= n - 1; i++)
			{
				prefix = commonPrefixUtil(prefix,
							arr.GetValue(i).ToString());
			}

			return (prefix);
		}
	}
}
