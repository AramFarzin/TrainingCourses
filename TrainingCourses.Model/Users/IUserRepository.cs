using System.Collections.Generic;
using TrainingCourses.Core;

namespace TrainingCourses.Model.Users
{
    public interface IUserRepository : IRepository
    {
        void Add(User user);

        IEnumerable<User> GetAll();
    }
}