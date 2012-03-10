using System;

namespace RomanNumeralsKata
{
	public class RomanNumeral
	{
		public static string Parse (int arabicNumeral)
		{
			string romanNumeral = string.Empty;
			
			for (int i = 0; i < arabicNumeral; i++)
				romanNumeral += "I";			
			
			return romanNumeral;
		}
	}
}

