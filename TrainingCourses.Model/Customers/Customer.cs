using System;
using System.Collections.Generic;
using TrainingCourses.Common;
using TrainingCourses.Model.Users;

namespace TrainingCourses.Model.Customers
{
    public class Customer
    {
        public Guid Id { get; set; }
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
        public User CreatedBy { get; set; }
        public IList<Orders.Order> Orders { get; set; }
    }
}