using Bean.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bean.Services.Order
{
    public interface IOrderService
    {
        List<SalesOrder> GetOrders();
        ServiceResponse<bool> GenerateInvoiveForOrder(SalesOrder order);
        ServiceResponse<bool> MarkFufilled(int id);

    }
}
