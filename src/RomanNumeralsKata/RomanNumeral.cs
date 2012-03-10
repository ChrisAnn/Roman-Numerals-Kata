using System;

namespace RomanNumeralsKata
{
	public class RomanNumeral
	{
		public static string Parse (int arabicNumeral)
		{
			if (arabicNumeral == 1)
				return "I";
			else 
				return "II";
		}
	}
}

