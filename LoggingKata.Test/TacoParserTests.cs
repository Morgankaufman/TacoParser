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
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", -86.217115)]
        [InlineData("33.431706,-84.177113,Taco Bell McDonoug...", -84.177113)]
        public void ShouldParseLongitude(string line, double expected)
        {
            
            var parser = new TacoParser();

            
            var actual = parser.Parse(line);
            
            Assert.Equal(expected, actual.Location.Longitude);
        }


        

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", 34.280205)]
        [InlineData("33.431706,-84.177113,Taco Bell McDonoug...", 33.431706)]
        public void shouldParseLatitude(string line, double expected)
        {
            var parser = new TacoParser();

            var actual = parser.Parse(line);

            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
