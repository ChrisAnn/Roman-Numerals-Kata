using System;

namespace RomanNumeralsKata
{
	public class RomanNumeral
	{
		public static string Parse (int arabicNumeral)
		{
			if (arabicNumeral == 4)
				return "IV";
			
			if (arabicNumeral == 5)
				return "V";
			
			string romanNumeral = string.Empty;
			
			for (int i = 0; i < arabicNumeral; i++)
				romanNumeral += "I";			
			
			return romanNumeral;
		}
	}
}

