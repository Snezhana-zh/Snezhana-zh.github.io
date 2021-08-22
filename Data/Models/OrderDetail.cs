using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }//для БД
        public int orderID { get; set; }
        public int CarID { get; set; }
        public uint price { get; set; }
        public virtual Car car { get; set; }//virtual-ключевое слово, объект машины
        public virtual Order order { get; set; }//заказ с которым мы работаем, нужны для связи
    }
}
