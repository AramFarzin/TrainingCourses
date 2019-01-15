using System;

namespace Decorator
{
    internal class DailyMeeting : AbstractMeeting
    {
        internal override void SetMeeting()
        {
            Console.WriteLine("Daily meeting");
        }
    }
}