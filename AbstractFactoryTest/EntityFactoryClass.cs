using System.ComponentModel;

namespace AbstractFactoryTest
{
    public class FactoryProducer
    {
        public IFactoryClass GetFactory(EntityType entityType)
        {
            switch (entityType)
            {
                case EntityType.Customer:
                    return new CustomerFactoryClass();

                case EntityType.Meeting:
                    return new MeetingFactoryClass();

                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}