using System;
using System.Collections.Generic;
using System.Linq;
using TrainingCourses.Core;

namespace TrainingCourses.Model.Orders
{
    public class OrderRepository : IRepository<Order>
    {
        private static readonly List<Order> Orders = new List<Order>();

        public Order GetBy(Guid id)
        {
            return Orders.SingleOrDefault(o => o.Id == id);
        }

        public void Create(Order t)
        {
            Orders.Add(t);
        }

        public void Update(Order t)
        {
            Orders.Remove(Orders.SingleOrDefault(o => o.Id == t.Id));
            Orders.Add(t);
        }

        public void Delete(Order t)
        {
            Orders.Remove(t);
        }

        public IList<Order> GetAll()
        {
            return Orders;
        }
    }
}