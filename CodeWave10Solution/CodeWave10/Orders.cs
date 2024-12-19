using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWave10
{
    internal class Orders
    {
        public OrderStatus OrderStatus { get; set; }
        public Orders()
        {
            OrderStatus = OrderStatus.Pending;
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            OrderStatus = newStatus;
            Console.WriteLine($"Order is {OrderStatus} now.");
        }

    }
}
