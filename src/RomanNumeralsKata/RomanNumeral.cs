using System;

namespace RomanNumeralsKata
{
	public class RomanNumeral
	{
		public static string Parse (int arabicNumeral)
		{
			if (arabicNumeral == 4)
				return "IV";
			
			string romanNumeral = string.Empty;
			
			var noFives = arabicNumeral / 5;
			if (noFives == 1)
			{
				romanNumeral = "V";
				arabicNumeral -= 5;
			}
			
			for (int i = 0; i < arabicNumeral; i++)
				romanNumeral += "I";			
			
			return romanNumeral;
		}
	}
}

