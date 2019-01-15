using System;

namespace Decorator
{
    internal class DailyMeeting : IMeeting
    {
        public void SetMeeting()
        {
            Console.WriteLine("Daily meeting");
        }
    }
}