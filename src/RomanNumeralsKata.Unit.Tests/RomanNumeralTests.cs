using System;
using NUnit.Framework;
using RomanNumeralsKata;

namespace RomanNumeralsKata.Unit.Tests
{
	[TestFixture]
	public class RomanNumeralTests
	{
		[Test]
		public void Should_parse_one_to_I ()
		{
			var output = RomanNumeral.Parse (1);
			
			Assert.That (output, Is.EqualTo ("I"));
		}
		
		[Test]
		public void Should_parse_two_to_II ()
		{
			var output = RomanNumeral.Parse (2);
			
			Assert.That (output, Is.EqualTo ("II"));
		}
		
		[Test]
		public void Should_parse_three_to_III ()
		{
			var output = RomanNumeral.Parse (3);
			
			Assert.That (output, Is.EqualTo ("III"));
		}
	}
}

