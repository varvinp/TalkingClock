using System;
using NUnit.Framework;
using HumanFriendlyClock;

namespace Tests
{
    public class TimeExtensionTest
    {

        [Test]
        [TestCase(0, "Zero")]
        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(55, "Fifty Five")]
        [TestCase(30, "Half")]
        public void NumberToWordsShouldReturnString(int input, string expectedOutput)
        {
            
            // Act
            var result = input.NumberToWords();
            //Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void NumberToWordsShouldRaiseException()
        {
            var input = 60;
            Assert.Throws<IndexOutOfRangeException>(()=>input.NumberToWords());
        }
    }
}