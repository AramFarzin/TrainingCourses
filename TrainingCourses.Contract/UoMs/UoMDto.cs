using System;
using TrainingCourses.Contract.Users;

namespace TrainingCourses.Contract.UoMs
{
    public class UoMDto
    {
        public Guid UoMId { get; set; }
        public string Name { get; set; }
        public UoMDto BaseUoM { get; set; }
        public double Multiples { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public UserDto CreatedBy { get; set; }
    }
}