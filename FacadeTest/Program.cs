using System;

namespace FacadeTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meeting = new MeetingMaker();
            meeting.SetDailyMeeting();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            meeting.SetPlanningMeeting();
            Console.ReadLine();
        }
    }
}