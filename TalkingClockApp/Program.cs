using System;

namespace TalkingClockApp
{
    public class Program
    {
        private static volatile bool _stop = false;

        private static void Main()
        {
            while (!_stop)
            {
                try
                {

                    Console.CancelKeyPress += Console_CancelKeyPress;
                    Console.WriteLine("Write time or press enter for time. Press CTRL+C to cancel.");
                    var inputTime = Console.ReadLine();

                    var humanFriendlyTime = HumanFriendlyTime.GetHumanFriendlyTime(inputTime);

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


        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            e.Cancel = true;
            _stop = true;
            Console.WriteLine("Cancelling...");
        }
    }
}
