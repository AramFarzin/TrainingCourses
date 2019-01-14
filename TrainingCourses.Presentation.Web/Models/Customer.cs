using System;
using System.Collections.Generic;
using PresentationTier.Models.Enums;

namespace PresentationTier.Models
{
    public class Customer
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
        public User CreatedBy { get; set; }
        public IList<Order> Orders { get; set; }
    }
}