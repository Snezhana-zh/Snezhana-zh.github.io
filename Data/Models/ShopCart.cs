using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent) //конструктор, он называется как класс 
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }

        public List<ShopCartItem> listShopItems { get; set; }//прописать конструктор и подключить AppDBContent, это делается в Repository

        //функция static, потому что надо будет вызывать из других классов
        public static ShopCart GetCart(IServiceProvider services) //работаем с сервисами
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            //Создание сессии(объекта для работы с сессиями): подключаем класс ISession для работы с сессиями, обращаемся к парамеру services, потом к GetRequiredService, затем обращаемся к классу IHttpContextAccessor

            var context = services.GetService<AppDBContent>();//переменная, с помощью AppDBContent получаем таблички и работаем с БД

            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); //(ID корзины, может быть пустой, товары распределяются по разным корзинам) мы устанавливаем значение из сессии, если его нет то устанавливаем новое
            session.SetString("CartId", shopCartId);//ключ CartId,значение shopCartId;с shopCartId возвращает значение
            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)//объект который добавляем
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem //создание нового объекта на основе класса 
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            });
            appDBContent.SaveChanges();
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();// объекты у которых айди корзины равно айди корзины в сессии; ShopCartItem значит получить
        }
    }
}
