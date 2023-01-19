﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bean.Data.Models
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public List<SalesOrderItem> SalesOrderItems { get; set; }
        public bool IsPaid { get; set; }

    }
}
