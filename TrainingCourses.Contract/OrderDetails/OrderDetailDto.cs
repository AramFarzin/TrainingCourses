using System;
using TrainingCourses.Contract.Orders;
using TrainingCourses.Contract.Products;
using TrainingCourses.Contract.UoMs;
using TrainingCourses.Contract.Users;

namespace TrainingCourses.Contract.OrderDetails
{
    public class OrderDetailDto
    {
        public Guid OrderDetailId { get; set; }
        public ProductDto Product { get; set; }
        public OrderDto OrderDto { get; set; }
        public bool ManualPrice { get; set; }
        public UoMDto UoM { get; set; }
        public long PricePerUoM { get; set; }
        public long DiscountPerUoM { get; set; }
        public long Quantity { get; set; }
        public long TotalAmount { get; set; }
        public long TotalLineItemAmount { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public UserDto CreatedBy { get; set; }
    }
}