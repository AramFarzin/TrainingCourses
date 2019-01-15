using System.Collections.Generic;

namespace TrainingCourses.Model
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> users = new List<User>();

        public void Add(User user)
        {
            users.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }
    }
}