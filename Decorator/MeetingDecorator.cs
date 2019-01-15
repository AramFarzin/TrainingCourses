using System;

namespace Decorator
{
    internal abstract class MeetingDecorator : IMeeting
    {
        protected IMeeting DecoratorAbstractMeeting;

        protected MeetingDecorator(IMeeting meeting)
        {
            DecoratorAbstractMeeting = meeting;
        }

        public abstract void SetMeeting();
    }
}