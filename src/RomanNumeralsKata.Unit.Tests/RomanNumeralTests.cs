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
			
			Assert.That(output, Is.EqualTo("I"));
		}
	}
}

