using System;
using TrainingCourses.Model.Users;

namespace TrainingCourses.Model.UoMs
{
    public class UoM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UoM BaseUoM { get; set; }
        public double Multiples { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}