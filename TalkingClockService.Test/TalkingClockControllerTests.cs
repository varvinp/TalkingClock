using System.Net.Http;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using TalkingClockService.Controllers;

namespace Tests
{
    public class TalkingClockControllerTests
    {
        [Test]
        public void TalkingClockControllerGetShouldReturnHumanFriendlyTime()
        {
            // Arrange
            var controller = new TalkingClockController();

            // Act
            var result = controller.Get("15:30");

            var response = ((JValue)((JProperty)result.Value.First).Value).Value;

            var expected = "Half past three";
            // Assert
            Assert.AreEqual(expected, response);
        }

        [Test]
        public void TalkingClockControllerGetShouldReturnValidJsonKey()
        {
            // Arrange
            var controller = new TalkingClockController();

            // Act
            var result = controller.Get("15:30");

            var expected = result.Value.ContainsKey("Human Friendly Text");
            // Assert
            Assert.IsTrue(expected);
        }

        [Test]
        public void TalkingClockControllerGetShouldRaiseException()
        {
            // Arrange
            var controller = new TalkingClockController();

            // Assert
            Assert.Throws<HttpRequestException>(() => controller.Get("56:00"));
        }
    }
}