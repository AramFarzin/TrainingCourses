using System;
using TrainingCourses.Model.UoMs;
using TrainingCourses.Model.Users;

namespace TrainingCourses.Model.PriceLevels
{
    public class PriceLevel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UoM UoM { get; set; }
        public long Min { get; set; }
        public long Max { get; set; }
        public float TaxRate { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}