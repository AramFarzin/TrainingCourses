using System;

namespace MVCTest.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Status Status { get; set; }

        public String GetFullName()
        {
            return FirstName != null ? FirstName + " " + LastName : LastName;
        }
    }
}