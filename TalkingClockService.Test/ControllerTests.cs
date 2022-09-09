using Newtonsoft.Json.Linq;
using NUnit.Framework;
using TalkingClockService.Controllers;

namespace Tests
{
    public class ControllerTests
    {
        [Test]
        public void ControllerGetShouldReturnHumanFriendlyTime()
        {
            // Arrange
            var conroller = new TalkingClockController();

            // Act
            var result = conroller.Get("15:30");

            var response = ((JValue)((JProperty)result.Value.First).Value).Value;

            var expected = "Half past three";
            // Assert
            Assert.AreEqual(expected, response);
        }

        [Test]
        public void ControllerGetShouldReturnValidJsonKey()
        {
            // Arrange
            var conroller = new TalkingClockController();

            // Act
            var result = conroller.Get("15:30");

            var expected = result.Value.ContainsKey("Human Friendly Text");
            // Assert
            Assert.IsTrue(expected);
        }
    }
}