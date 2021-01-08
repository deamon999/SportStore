using DBService.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace DBService.Repositories
{
    public interface IOrdersRepository
    {
        IEnumerable<Order> Orders { get; }
        Order GetOrder(long key);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
