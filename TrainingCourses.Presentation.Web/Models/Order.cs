using System;
using System.Collections.Generic;
using PresentationTier.Models.Enums;

namespace PresentationTier.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
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