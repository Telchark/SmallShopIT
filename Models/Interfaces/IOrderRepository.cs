using System;

namespace SmallShopIT.Models
{
    public interface IOrderRepository
    {
        decimal CreateOrder(Order order);
    }
}
