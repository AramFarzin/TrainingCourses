using System;

namespace TrainingCourses.Model
{
    public class UoM
    {
        public Guid UoMId { get; set; }
        public string Name { get; set; }
        public UoM BaseUoM { get; set; }
        public double Multiples { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}