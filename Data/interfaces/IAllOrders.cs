using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);//создает заказ
    }
}
