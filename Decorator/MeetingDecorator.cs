using System;

namespace Decorator
{
    internal abstract class MeetingDecorator : AbstractMeeting
    {
        protected AbstractMeeting DecoratorAbstractMeeting;

        protected MeetingDecorator(AbstractMeeting abstractMeeting)
        {
            DecoratorAbstractMeeting = abstractMeeting;
        }

        internal override void SetMeeting()
        {
            DecoratorAbstractMeeting.SetMeeting();
            // add other codes
            Console.WriteLine("Virtual Meeting");
        } 
    }
}