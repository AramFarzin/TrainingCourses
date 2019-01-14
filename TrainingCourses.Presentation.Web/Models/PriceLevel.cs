using System;

namespace PresentationTier.Models
{
    public class PriceLevel
    {
        public Guid PriceLevelId { get; set; }
        public string Name { get; set; }
        public UoM UoM { get; set; }
        public long Min { get; set; }
        public long Max { get; set; }
        public Single TaxRate { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}