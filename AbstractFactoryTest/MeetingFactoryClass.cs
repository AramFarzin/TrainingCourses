using System.ComponentModel;

namespace AbstractFactoryTest
{
    public class MeetingFactoryClass : IFactoryClass
    {
        public IMeeting Getmeeting(MeetingType meetingType)
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

        public ICustomer GetCustomer(CustomerType customerType)
        {
            return null;
        }
    }
}