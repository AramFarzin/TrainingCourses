using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meeting = new VirtualMeeting(new PlanningMeeting());
            meeting.SetMeeting();
            Console.ReadLine();
        }
    }
}