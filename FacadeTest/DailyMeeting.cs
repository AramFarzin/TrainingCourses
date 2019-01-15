using System;

namespace FacadeTest
{
    internal class DailyMeeting:IMeeting
    {
        public void SetMeeting()
        {
            Console.WriteLine("Daily meeting set up every day at 10:00");
        }
    }
}