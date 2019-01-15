namespace IteratorTest
{
    internal class MeetingRepository : IContainer
    {
        public static string[] Meetings = {"Daily", "Planing", "Groomig", "Review", "Retrospective"};

        public IIterator GetIterator()
        {
            return new MeetingIterator();
        }

        private class MeetingIterator : IIterator
        {
            private int index;

            public bool HasNext()
            {
                if (index < Meetings.Length) return true;

                return false;
            }

            public object Next()
            {
                if (HasNext()) return Meetings[index++];

                return null;
            }
        }
    }
}