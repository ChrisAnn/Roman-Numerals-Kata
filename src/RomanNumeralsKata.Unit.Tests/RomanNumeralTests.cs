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
			var output = new RomanNumeral().Parse (1);
			
			Assert.That (output, Is.EqualTo ("I"));
		}
		
		[Test]
		public void Should_parse_two_to_II ()
		{
			var output = new RomanNumeral().Parse (2);
			
			Assert.That (output, Is.EqualTo ("II"));
		}
		
		[Test]
		public void Should_parse_three_to_III ()
		{
			var output = new RomanNumeral().Parse (3);
			
			Assert.That (output, Is.EqualTo ("III"));
		}
		
		[Test]
		public void Should_parse_4_to_IV ()
		{
			var output = new RomanNumeral().Parse (4);
			
			Assert.That (output, Is.EqualTo ("IV"));
		}
		
		[Test]
		public void Should_parse_5_to_V ()
		{
			var output = new RomanNumeral().Parse (5);
			
			Assert.That (output, Is.EqualTo ("V"));
		}
		
		[Test]
		public void Should_parse_6_to_VI ()
		{
			var output = new RomanNumeral().Parse (6);
			
			Assert.That (output, Is.EqualTo ("VI"));
		}
		
		[Test]
		public void Should_parse_10_to_X ()
		{
			var output = new RomanNumeral().Parse (10);
			
			Assert.That (output, Is.EqualTo ("X"));
		}
		
		[Test]
		public void Should_parse_20_to_XX ()
		{
			var output = new RomanNumeral().Parse (20);
			
			Assert.That (output, Is.EqualTo ("XX"));
		}
		
		[Test]
		public void Should_parse_50_to_L ()
		{
			var output = new RomanNumeral ().Parse (50);
			
			Assert.That (output, Is.EqualTo ("L"));
		}
	}
}

