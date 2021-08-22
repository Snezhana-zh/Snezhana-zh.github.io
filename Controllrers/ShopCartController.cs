using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;
using WebApplication2.ViewModels;
using WebApplication2.Data.interfaces;

namespace WebApplication2.Controllrers
{
    public class ShopCartController : Controller //наследует все от класса Controller 
    {

        private readonly IAllCars _carRep;//Repository-это реализация интерфейсов, мы подключаем сами интерфейсы
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }//контроллер

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        } //функция возвращает html шаблон

        public RedirectToActionResult addToCart(int id) //переадресация на другую страницу
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.id == id); //из БД выбирает нужный товар по id

            if(item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");// когда будет добавлен товар, пользователь будет направлен на страничку с корзиной

        }//FirstOrDefault первый элемент или тот что нужен
    }
}
