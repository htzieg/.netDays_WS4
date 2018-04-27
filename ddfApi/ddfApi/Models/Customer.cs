using System;
using System.Collections.Generic;
using System.Text;

namespace ddfApi.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
