using System.Collections.Generic;
using TrainingCourses.Core;

namespace TrainingCourses.Contract.Users
{
    public interface IUserFacadeService : IFacadeService
    {
        void Add(UserDto user);

        IEnumerable<UserDto> GetAll();
    }
}