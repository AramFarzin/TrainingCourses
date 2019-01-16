using System;
using System.Collections.Generic;
using TrainingCourses.Common;
using TrainingCourses.Contract.Orders;

namespace TrainingCourses.Contract.Users
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + LastName;
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserStatus StatusCode { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public UserDto CreatedBy { get; set; }
        public virtual IList<OrderDto> Orders { get; set; }
    }
}