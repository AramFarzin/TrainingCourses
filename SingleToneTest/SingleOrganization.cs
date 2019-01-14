namespace SingletoneTest
{
    public class SingleOrganization
    {
        private static readonly SingleOrganization Organization = new SingleOrganization();

        private SingleOrganization()
        {
          
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public static SingleOrganization GetOrganization()
        {
            return Organization;
        }
    }
}