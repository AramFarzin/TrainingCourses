using System;

namespace Decorator
{
    internal class PlanningMeeting : IMeeting
    {
        public void SetMeeting()
        {
            Console.WriteLine("Planning meeting");
        }
    }
}