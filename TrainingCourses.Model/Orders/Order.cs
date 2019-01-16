using System;
using System.Collections.Generic;
using TrainingCourses.Common;
using TrainingCourses.Model.OrderDetails;
using TrainingCourses.Model.Users;

namespace TrainingCourses.Model.Orders
{
    public class Order
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public string Name { get; set; }
        public User SalesManager { get; set; }
        public OrderStatus StatusCode { get; set; }
        public long TotalTax { get; set; }
        public long DiscountPerOrder { get; set; }
        public long TotalDiscount { get; set; }
        public long TotalAmount { get; set; }
        public string Description { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
        public IList<OrderDetail> OrderDetails { get; set; }
    }
}