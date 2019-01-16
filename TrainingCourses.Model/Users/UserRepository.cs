using System.Collections.Generic;

namespace TrainingCourses.Model.Users
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> Users = new List<User>();

        public void Add(User user)
        {
            Users.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return Users;
        }
    }
}