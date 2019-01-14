using System;
using System.Collections;
using System.Collections.Generic;
using PresentationTier.Models.Enums;

namespace PresentationTier.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserStatus StatusCode { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
        public IList<Order> Orders { get; set; }
    }
}