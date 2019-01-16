using System;
using TrainingCourses.Model.UoMs;
using TrainingCourses.Model.Users;

namespace TrainingCourses.Model.OrderDetails
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Products.Product Product { get; set; }
        public Orders.Order Order { get; set; }
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