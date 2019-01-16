using System;
using System.Collections.Generic;
using TrainingCourses.Common;
using TrainingCourses.Model.PriceLevels;
using TrainingCourses.Model.Users;

namespace TrainingCourses.Model.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProductKey { get; set; }
        public ProductStatus StatusCode { get; set; }
        public List<PriceLevel> PriceLevels { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}