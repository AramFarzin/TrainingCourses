using System;

namespace Decorator
{
    internal class VirtualMeeting : MeetingDecorator
    {
        public VirtualMeeting(IMeeting meeting) : base(meeting)
        {
        }

        public override void SetMeeting()
        {
            DecoratorAbstractMeeting.SetMeeting();
            // add other codes
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Virtual Meeting");
        }
    }
}