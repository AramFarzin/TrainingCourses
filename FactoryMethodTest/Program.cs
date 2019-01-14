using System;

namespace FactoryMethodTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Factory method create object without exposing client with creation logic
            var meeting = new MeetingFactoryClass();
            Console.WriteLine(meeting.GetMeeting(MeetingType.Review).ToString());
            Console.ReadLine();
        }
    }
}