using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
          
            var tacoParser = new TacoParser();

            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.679723,-84.487535,Taco Bell East Ellija...", -84.487535)]
        public void ShouldParseLongitude(string line, double expected)
        {

            var longitude = new TacoParser();

            var actual = longitude.Parse(line).Location.Longitude;

            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("33.47132,-84.4473,Taco Bell Fayetteville/1...", 33.47132)]
        [InlineData("31.236691,-85.459825,Taco Bell Dothan...", 31.236691)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var latitude = new TacoParser();

            var actual = latitude.Parse(line).Location.Latitude;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Taco Bell Blue Ridg...", "Taco Bell Fole...")]

    }
}
