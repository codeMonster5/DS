using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings
{
	public static class Atoi
	{

		// A simple atoi() function. If the given string contains 
		// any invalid character, then this function returns 0 
		public static int atoi(String str)
		{

			if (str.Length == 0)
			{
				return -1;
			}
			int sign = 1; // Initialize sign as positive 
			int res = 0; // Initialize result 
			int i = 0; // Initialize index of first digit 

			// If number is negative, then update sign 
			if (str[i] == '-')
			{
				sign = -1;
				i++; // Also update index of first digit 
			}

			// Iterate through all digits of input 
			// string and update result 
			for (; i < str.Length; i++)
			{
				if (char.IsDigit(str[i]) == false)
				{
					return -1;
				}
				res = res * 10 + int.Parse(str[i].ToString());
			}

			return sign * res;
		}

	
	}

}
