using System;

namespace HumanFriendlyClock
{
    public static class Time
    {
        public static string GetHumanFriendlyTime(DateTime time)
        {
            var hour = time.Hour > 12 ? time.Hour - 12 : time.Hour;

            return time.Minute == 0 ? hour.NumberToWords() + " O'Clock" : (time.Minute > 30 ? (60 - time.Minute).NumberToWords() + " to " + (hour + 1).NumberToWords().ToLower() : time.Minute.NumberToWords() + " past " + hour.NumberToWords().ToLower());
        }
    }
}
