using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using TalkingClockApp;
using Program = TalkingClockApp.Program;

namespace Tests
{
    public class ProgramTests
    {

        [Test]
        public void ShowHumanFriendlyTimeShouldHaveCorrectHumanFriendlyText()
        {
            var result = Program.GetHumanFriendlyTime("15:30");
           Assert.AreEqual("Half past three",result);
        }
    }
}