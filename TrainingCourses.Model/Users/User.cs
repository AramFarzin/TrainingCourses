using System;
using System.Collections.Generic;
using TrainingCourses.Common;

namespace TrainingCourses.Model.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + LastName;
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserStatus StatusCode { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public User CreatedBy { get; set; }
        public virtual IList<Orders.Order> Orders { get; set; }
    }
}