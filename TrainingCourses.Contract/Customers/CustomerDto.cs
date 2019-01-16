using System;
using System.Collections.Generic;
using TrainingCourses.Common;
using TrainingCourses.Contract.Orders;
using TrainingCourses.Contract.Users;

namespace TrainingCourses.Contract.Customers
{
    public class CustomerDto
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string PostalMailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNumber { get; set; }
        public CustomerStatus StatusCode { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public UserDto CreatedBy { get; set; }
        public IList<OrderDto> Orders { get; set; }
    }
}