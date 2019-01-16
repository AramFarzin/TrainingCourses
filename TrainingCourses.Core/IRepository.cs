using System;
using System.Collections.Generic;

namespace TrainingCourses.Core
{
    public interface IRepository
    {
    }

    public interface IRepository<T>
    {
        IList<T> GetAll();
        T GetBy(Guid id);
        void Create(T t);
        void Update(T t);
        void Delete(T t);
    }
}