﻿using Bean.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bean.Services.Order
{
    public class OrderService : IOrderService
    {
        public ServiceResponse<bool> GenerateInvoiveForOrder(SalesOrder order)
        {
            throw new NotImplementedException();
        }

        public List<SalesOrder> GetOrders()
        {
            throw new NotImplementedException();
        }

        public ServiceResponse<bool> MarkFufilled(int id)
        {
            throw new NotImplementedException();
        }
    }
}
