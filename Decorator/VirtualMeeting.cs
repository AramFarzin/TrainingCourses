using System;

namespace Decorator
{
    internal class VirtualMeeting 
    {
        protected IMeeting DecoratorMeeting;
        public VirtualMeeting(IMeeting meeting)
        {
            DecoratorMeeting = meeting;
        }

        public void SetMeeting()
        {
            DecoratorMeeting.SetMeeting();
            // add other codes
            Console.WriteLine("Virtual Meeting");
        } 
    }
}