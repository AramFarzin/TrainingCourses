using System;

namespace IteratorTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var meetings = new MeetingRepository().GetIterator();
            for (var i = meetings; i.HasNext();
                )
            {
                var meetingName = (string) i.Next();
                Console.WriteLine(meetingName);
            }

            Console.ReadLine();
        }
    }
}