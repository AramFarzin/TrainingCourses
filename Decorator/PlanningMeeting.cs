using System;

namespace Decorator
{
    internal class PlanningMeeting : AbstractMeeting
    {
        internal override void SetMeeting()
        {
            Console.WriteLine("Planning meeting");
        }
    }
}