using System;

namespace CompositeTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var scrumMeeting = new Meeting
            {
                Id = 1,
                Name = "ScrumMeeting"
            };

            var dailyMeeting = new Meeting
            {
                Id = 2,
                Name = "DailyMeeting"
            };

            var planningMeeting = new Meeting
            {
                Id = 3,
                Name = "planningMeeting"
            };
            scrumMeeting.Add(dailyMeeting);
            scrumMeeting.Add(planningMeeting);

            foreach (var scrumMeetingSubMeeting in scrumMeeting.SubMeetings)
                Console.WriteLine(scrumMeetingSubMeeting.Name);

            Console.ReadLine();
        }
    }
}