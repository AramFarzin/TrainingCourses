using System.Collections.Generic;

namespace TrainingCourses.Model
{
    public interface IUserRepository
    {
        void Add(User user);

        IEnumerable<User> GetAll();
    }
}