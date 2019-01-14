using System.ComponentModel;

namespace FactoryMethodTest
{
    internal class MeetingFactoryClass
    {
        public IMeeting GetMeeting(MeetingType meetingType)
        {
            switch (meetingType)
            {
                case MeetingType.Sprint:
                    return new SprintPlaningMeeting();

                case MeetingType.Standup:
                    return new StandupMeeting();

                case MeetingType.Grooming:
                    return new GroomingMeeting();

                case MeetingType.Review:
                    return new ReviewMeeting();

                case MeetingType.Retrospective:
                    return new RetrospectiveMeeting();

                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}