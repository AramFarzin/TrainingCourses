using System;
using System.Collections.Generic;
using TrainingCourses.Common;
using TrainingCourses.Contract.PriceLevels;
using TrainingCourses.Contract.Users;

namespace TrainingCourses.Contract.Products
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string ProductKey { get; set; }
        public ProductStatus StatusCode { get; set; }
        public List<PriceLevelDto> PriceLevels { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public UserDto CreatedBy { get; set; }
    }
}