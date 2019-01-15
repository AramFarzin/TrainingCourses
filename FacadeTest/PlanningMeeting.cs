using System;

namespace FacadeTest
{
    internal class PlanningMeeting : IMeeting
    {
        public void SetMeeting()
        {
            Console.WriteLine("Planning meeting set up every saturday at 8:00");
        }
    }
}