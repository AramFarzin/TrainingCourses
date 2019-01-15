using System;

namespace TrainingCourses.Model
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public bool ManualPrice { get; set; }
        public UoM UoM { get; set; }
        public long PricePerUoM { get; set; }
        public long DiscountPerUoM { get; set; }
        public long Quantity { get; set; }
        public long TotalAmount { get; set; }
        public long TotalLineItemAmount { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
    }
}