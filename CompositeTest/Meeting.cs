using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositeTest
{
    internal class Meeting
    {
        public Meeting()
        {
            SubMeetings = new List<Meeting>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Meeting> SubMeetings { get; set; }

        public void Add(Meeting meeting)
        {
            SubMeetings.Add(meeting);
        }

        public void Remove(Meeting meeting)
        {
            SubMeetings.Remove(meeting);
        }
        
        public List<Meeting> GetSubMeetings()
        {
            return SubMeetings;
        }
    }
}