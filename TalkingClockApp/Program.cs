using System;
using HumanFriendlyClock;

namespace TalkingClockApp
{
   public class Program
    {
        private static volatile bool _s_stop = false;
        static void Main()
        {            
            
            while (!_s_stop)
            {
                ShowHumanFriendlyTime();
            } 
        }

        private static void ShowHumanFriendlyTime()
        {
            try
            {
                Console.CancelKeyPress += Console_CancelKeyPress;
                Console.WriteLine("Write time or press enter for time. Press CTRL+C to cancel.");
                var inputTime = Console.ReadLine();

                var humanFriendlyTime = GetHumanFriendlyTime(inputTime);

                Console.WriteLine(humanFriendlyTime);
                Console.WriteLine();
                Console.CancelKeyPress -= Console_CancelKeyPress;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured. Please see message: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }
        public static string GetHumanFriendlyTime(string inputTime)
        {
            return string.IsNullOrEmpty(inputTime) ? Time.GetHumanFriendlyTime(DateTime.Now) : Time.GetHumanFriendlyTime(Convert.ToDateTime(inputTime));
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            _s_stop = true;
            Console.WriteLine("Cancelling...");
        }
    }
}
