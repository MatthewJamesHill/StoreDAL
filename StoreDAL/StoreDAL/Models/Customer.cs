using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreDAL.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int HomePhone { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}
