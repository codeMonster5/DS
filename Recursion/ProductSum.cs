using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Recursion
{
    public static class ProductSums
    {
	
			// Tip: You can use `el is IList<object>` to check whether an item is a list or
			// an integer.
			public static int ProductSum(List<object> array)
			{
				// Write your code here.
				return productSum(array, 1);
			}

			public static int productSum(List<object> array, int multiplier)
			{

				int sum = 0;

				foreach (object el in array)
				{

					if (el is IList<object>)
					{

						sum += productSum((List<object>)el, multiplier + 1);

					}
					else
					{
						sum += (int)el;
					}
				}
				return sum * multiplier;
			}
		}

	}

