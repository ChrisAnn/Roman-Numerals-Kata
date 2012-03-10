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
		
		[Test]
		public void Should_parse_4_to_IV ()
		{
			var output = RomanNumeral.Parse (4);
			
			Assert.That (output, Is.EqualTo ("IV"));
		}
		
		[Test]
		public void Should_parse_5_to_V ()
		{
			var output = RomanNumeral.Parse (5);
			
			Assert.That (output, Is.EqualTo ("V"));
		}
		
		[Test]
		public void Should_parse_6_to_VI ()
		{
			var output = RomanNumeral.Parse (6);
			
			Assert.That (output, Is.EqualTo ("VI"));
		}
		
		[Test]
		public void Should_parse_10_to_X ()
		{
			var output = RomanNumeral.Parse (10);
			
			Assert.That (output, Is.EqualTo ("X"));
		}
	}
}

