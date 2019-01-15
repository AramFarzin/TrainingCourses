﻿using System;

namespace Decorator
{
    internal class VirtualMeeting : AbstractMeeting
    {
        protected AbstractMeeting DecoratorAbstractMeeting;
        public VirtualMeeting(AbstractMeeting abstractMeeting)
        {
            DecoratorAbstractMeeting = abstractMeeting;
        }

        internal override void SetMeeting()
        {
            DecoratorAbstractMeeting.SetMeeting();
            // add other codes
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Virtual Meeting");
        } 
    }
}