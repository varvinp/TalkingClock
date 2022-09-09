using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using TalkingClockApp;

namespace Tests
{
    public class HumanFriendlyTime
    {

        [Test]
        public void ShowHumanFriendlyTimeShouldHaveCorrectHumanFriendlyText()
        {
            var result = TalkingClockApp.HumanFriendlyTime.GetHumanFriendlyTime("15:30");
           Assert.AreEqual("Half past three",result);
        }
    }
}