using System;
using SuportesBalanceados;
using Xunit;

namespace SupotesBanlanceados.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData("(){}[]", true)]
        [InlineData("[{()}](){}", true)]
        [InlineData("[{{[{()}](){}[()()()]()}}]", true)]
        [InlineData("[{(](){}", false)]
        [InlineData("[{(](){}{}", false)]
        [InlineData("[){(](){}", false)]
        [InlineData("[{()}){}", false)]
        [InlineData("))))))))))", false)]
        public void ValidString_ValidarString_RetornaSeAStringEhValida(string input, bool expected)
        {
            // Arrange
            var program = new Program();
            // Act
            var result = program.ValidString(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
