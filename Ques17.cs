using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    enum OrderStatuses
    {
        Pending,
        Packed,
        Shipped,
        Delivered,
        Cancelled
    }

    class Order
    {
        public OrderStatuses Status { get; private set; }

        public Order()
        {
            Status = OrderStatuses.Pending;
        }

        //Change order status
        public bool TryChangeStatus(OrderStatuses newStatus)
        {
            bool allowed = Status switch
            {
                OrderStatuses.Pending =>
                    newStatus == OrderStatuses.Packed ||
                    newStatus == OrderStatuses.Cancelled,

                OrderStatuses.Packed =>
                    newStatus == OrderStatuses.Shipped ||
                    newStatus == OrderStatuses.Cancelled,

                OrderStatuses.Shipped =>
                    newStatus == OrderStatuses.Delivered,

                OrderStatuses.Delivered => false,
                OrderStatuses.Cancelled => false,

                _ => false
            };
        }
    }
    public class Ques17
    {

    }
}
