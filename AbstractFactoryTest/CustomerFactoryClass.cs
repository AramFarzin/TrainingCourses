using System.ComponentModel;

namespace AbstractFactoryTest
{
    public class CustomerFactoryClass: IFactoryClass
    {
        public IMeeting Getmeeting(MeetingType meetingType)
        {
            return null;
        }

        public ICustomer GetCustomer(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Vip:
                    return new VipCustomer();

                case CustomerType.Loyal:
                    return new LoyalCustomer();

                case CustomerType.General:
                    return new GeneralCustomer();
                    
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}