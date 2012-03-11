using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
	public class RomanNumeral
	{
		private string _romanNumeral = string.Empty;
		private readonly IDictionary<int, string> _mappings = new Dictionary<int, string>();
		
		public RomanNumeral ()
		{
			_mappings.Add (1000, "M");
			_mappings.Add (900, "CM");
			_mappings.Add (500, "D");
			_mappings.Add (400, "CD");
			_mappings.Add (100, "C");
			_mappings.Add (90, "XC");
			_mappings.Add (50, "L");
			_mappings.Add (40, "XL");
			_mappings.Add (10, "X");
			_mappings.Add (9, "IX");
			_mappings.Add (5, "V");
			_mappings.Add (4, "IV");
		}
		
		public string Parse (int arabicNumeral)
		{						
			foreach (var mapping in _mappings)
			{
				arabicNumeral = ParseMultiples(arabicNumeral, mapping);
			}
			
			for (int i = 0; i < arabicNumeral; i++)
				_romanNumeral += "I";			
			
			return _romanNumeral;
		}

		private int ParseMultiples(int arabicNumeral, KeyValuePair<int,string> mapping)
		{
			var noMultiples = arabicNumeral / mapping.Key;
			for (int i = 0; i < noMultiples; i++)
			{
				_romanNumeral += mapping.Value;
			}
			
			return  arabicNumeral - (noMultiples * mapping.Key);
		}
	}
}

