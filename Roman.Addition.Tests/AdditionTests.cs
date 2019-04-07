using System;
using Xunit;

namespace Roman.Addition.Tests
{
    public class AdditionTests
    {
        [Theory] // This attribute tells xUnit that we're making multiple tests with this method
        [InlineData("I","I","II")]
        [InlineData("II","III","V")]
        [InlineData("II","II","IV")]
        [InlineData("IV","IV","VIII")]
        [InlineData("V","IV", "IX")]
        [InlineData("CMXCVIII","II", "M")]
        [InlineData("CMXCIX","I","M")]
        [InlineData("MCMXVIII","CI","MMXIX")]

        public void TestAdd(string roman1, string roman2, string expectedRomanSum)
        { 
            Assert.Equal(expectedRomanSum, new RomanNumeralAddtion().Add(roman1, roman2));
        }
    }
}
