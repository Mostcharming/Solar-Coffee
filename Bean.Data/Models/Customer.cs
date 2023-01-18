using System;
using System.Collections.Generic;
using System.Text;

namespace Bean.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerAdress PrimaryAddress { get; set; }
    }
}
