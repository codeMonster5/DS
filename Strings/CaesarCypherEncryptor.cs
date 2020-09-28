using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Strings
{
    public static class CaesarCypherEncryptors
    {
		public static string CaesarCypherEncryptor(string str, int key)
		{
			// Write your code here.
			char[] newLetters = new char[str.Length];
			int newKey = key % 26;
			for (int i = 0; i < str.Length; i++)
			{
				newLetters[i] = getNewLetter(str[i], newKey);
			}
			return new string(newLetters);
		}

		public static char getNewLetter(char letter, int key)
		{
			int newLetterCode = letter + key;
			return newLetterCode <=
				122 ? (char)newLetterCode : (char)(96 + newLetterCode % 122);
		}
	}
}

