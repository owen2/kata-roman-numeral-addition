using System;
using Xunit;

namespace Roman.Addition.Tests
{
    public class AdditionTests
    {
        [Theory] // This attribute tells xUnit that we're making multiple tests with this method
        [InlineData("I","I","II")]
        public void Test1(string roman1, string roman2, string expectedRomanSum)
        {

            Assert.Equal(expectedRomanSum, RomanNumeralAddtion.Add(roman1, roman2));
        }
    }
}
