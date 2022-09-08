using System;
using NUnit.Framework;
using HumanFriendlyClock;

namespace Tests
{
    public class TimeTest
    {
        [Test]
        [TestCase("1:00", "One O'Clock")]
        [TestCase("2:00", "Two O'Clock")]
        [TestCase("13:00", "One O'Clock")]
        [TestCase("13:05", "Five past one")]
        [TestCase("13:10", "Ten past one")]
        [TestCase("13:25", "Twenty Five past one")]
        [TestCase("13:30", "Half past one")]
        [TestCase("13:35", "Twenty Five to two")]
        [TestCase("13:55", "Five to two")]
        public void GetHumanFriendlyTimeShouldShowTimeWithText(string input, string expectedOutput)
        {
            // Arrange
            var timeToTest = Convert.ToDateTime(input);
            // Act
            var humanFriendlyTime =  Time.GetHumanFriendlyTime(timeToTest);
            //Assert
            Assert.AreEqual(expectedOutput, humanFriendlyTime);
        }

        [Test]
        public void GetHumanFriendlyTimeShouldShowCurrentHourWithText()
        {
            // Arrange
            var timeToTest = DateTime.Now;
            var hour = timeToTest.Hour > 12 ? timeToTest.Hour - 12 : timeToTest.Hour;
            var calculatedHour = (timeToTest.Minute > 30 ? hour + 1 : hour).NumberToWords().ToLower();

            // Act
            var humanFriendlyTime = Time.GetHumanFriendlyTime(timeToTest).ToLower();
            //Assert
            Assert.That(humanFriendlyTime.Contains(calculatedHour));
        }

        [Test]
        public void GetHumanFriendlyTimeShouldShowCurrentMinuteWithText()
        {
            // Arrange
            var timeToTest = DateTime.Now;
            var calculatedMinute = (timeToTest.Minute > 30 ? (60 - timeToTest.Minute) : timeToTest.Minute).NumberToWords();

            // Act
            var humanFriendlyTime = Time.GetHumanFriendlyTime(timeToTest);
            //Assert
            Assert.That(humanFriendlyTime.Contains(calculatedMinute));
        }

        [Test]
        public void GetHumanFriendlyTimeShouldShowPastOrTo()
        {
            // Arrange
            var timeToTest = DateTime.Now;
            var calculatedString = (timeToTest.Minute > 30 ? "to" : "past");

            // Act
            var humanFriendlyTime = Time.GetHumanFriendlyTime(timeToTest);
            //Assert
            Assert.That(humanFriendlyTime.Contains(calculatedString));
        }
    }
}