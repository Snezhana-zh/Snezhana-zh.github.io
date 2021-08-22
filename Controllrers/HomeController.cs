using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.interfaces;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllrers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;//Repository-это реализация интерфейсов, мы подключаем сами интерфейсы, доступ ко всем товарам которые у нас есть
      
        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;         
        }//конструктор

        public ViewResult Index()//возвращает шаблон
        {
            var homeCars = new HomeViewModel
            {
                farCars = _carRep.getFavCars
            };
            return View(homeCars);//передаем объекты которые отображаются на главной 
        }//новый контроллер - новая папка в Views(название как у контроллера)

    }
}
