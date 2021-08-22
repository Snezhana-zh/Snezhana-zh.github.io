using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication2.Data.interfaces;
using WebApplication2.Data.Models;
using Controller = Microsoft.AspNetCore.Mvc.Controller;

namespace WebApplication2.Controllrers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }//конструктор 

        public IActionResult Checkout()
        {
            return View();//возвращает шаблон, над которым будут производиться действия. IActionResult позволяет принимать данные.
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();

            if(shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("","У вас должны быть товары");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            
            return View(order);//возвращает шаблон, над которым будут производиться действия. IActionResult позволяет принимать данные.
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
