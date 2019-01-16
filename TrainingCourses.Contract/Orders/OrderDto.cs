using System;
using System.Collections.Generic;
using TrainingCourses.Common;
using TrainingCourses.Contract.OrderDetails;
using TrainingCourses.Contract.Users;

namespace TrainingCourses.Contract.Orders
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string Name { get; set; }
        public UserDto SalesManager { get; set; }
        public OrderStatus StatusCode { get; set; }
        public long TotalTax { get; set; }
        public long DiscountPerOrder { get; set; }
        public long TotalDiscount { get; set; }
        public long TotalAmount { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public UserDto CreatedBy { get; set; }
        public IList<OrderDetailDto> OrderDetails { get; set; }
    }
}