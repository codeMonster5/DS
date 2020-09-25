using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Arrays
{
   
		public class ProgramSpiralTraverse
		{
			public static List<int> SpiralTraverse(int[,] array)
			{
				if (array.GetLength(0) == 0) return new List<int>();

				var result = new List<int>();
				var startRow = 0;
				var endRow = array.GetLength(0) - 1;
				var startColumn = 0;
				var endColumn = array.GetLength(1) - 1;

				while (startRow <= endRow && startColumn <= endColumn)
				{

					for (int col = startColumn; col <= endColumn; col++)
					{
						result.Add(array[startRow, col]);
					}

					for (int row = startRow + 1; row <= endRow; row++)
					{
						result.Add(array[row, endColumn]);
					}

					for (int col = endColumn - 1; col >= startColumn; col--)
					{

						if (startRow == endRow) break;
						result.Add(array[endRow, col]);
					}

					for (int row = endRow - 1; row > startRow; row--)
					{

						if (startColumn == endColumn) break;
						result.Add(array[row, startColumn]);
					}

					startRow++;
					endRow--;
					startColumn++;
					endColumn--;

				}

				return result;
			}
		}
	}

