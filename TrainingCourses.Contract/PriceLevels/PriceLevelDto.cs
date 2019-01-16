using System;
using TrainingCourses.Contract.UoMs;
using TrainingCourses.Contract.Users;

namespace TrainingCourses.Contract.PriceLevels
{
    public class PriceLevelDto
    {
        public Guid PriceLevelId { get; set; }
        public string Name { get; set; }
        public UoMDto UoM { get; set; }
        public long Min { get; set; }
        public long Max { get; set; }
        public float TaxRate { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public UserDto CreatedBy { get; set; }
    }
}