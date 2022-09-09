using HumanFriendlyClock;
using System;

namespace TalkingClockApp
{
    public class HumanFriendlyTime
    {
        public static string GetHumanFriendlyTime(string inputTime)
        {
            return string.IsNullOrEmpty(inputTime) ? Time.GetHumanFriendlyTime(DateTime.Now) : Time.GetHumanFriendlyTime(Convert.ToDateTime(inputTime));
        }
    }
}
