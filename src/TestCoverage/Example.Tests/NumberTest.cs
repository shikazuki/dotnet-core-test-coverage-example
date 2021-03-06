using System;
using Xunit;
using Example;

namespace Example.Tests
{
    public class NumberTest
    {
        [Fact]
        public void IsEven_ValuesEqual2_ReturnTrue()
        {
            var actual = Number.IsEven(2);
            Assert.True(actual);
        }

        [Fact]
        public void IsEven_ValuesEqual3_ReturnFalse()
        {
            var actual = Number.IsEven(3);
            Assert.False(actual);
        }
    }
}
