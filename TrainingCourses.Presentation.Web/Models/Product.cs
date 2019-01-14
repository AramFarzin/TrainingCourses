using System;
using System.Collections.Generic;
using PresentationTier.Models.Enums;

namespace PresentationTier.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string ProductKey { get; set; }
        public ProductStatus StatusCode { get; set; }
        public List<PriceLevel> PriceLevels { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}