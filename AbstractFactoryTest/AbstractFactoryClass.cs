using System.ComponentModel;

namespace AbstractFactoryTest
{
    public interface IFactoryClass
    {
        IMeeting Getmeeting(MeetingType meetingType);
        ICustomer GetCustomer(CustomerType customerType);
    }
}