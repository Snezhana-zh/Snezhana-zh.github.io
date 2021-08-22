using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.interfaces;
using WebApplication2.Data.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllrers
{
    public class CarsController : Controller //наследует всё из класса Controller
    {
        private readonly IAllCars _allCars;//переменные на интерфейс
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars; //обращаясь к интерфейсу, мы обращаемся к классу,котрый реализует данный интерфейс. Мы можем управлять и использовать данные из классов и интерфейсов
            _allCategories = iCarsCat; //потому что мы связали интерфейсы и классы которые их реализуют в Startup: services.AddTransient<IAllCars, MockCars>();//командаобьединяет класс и его интерфейс<интерфейс,класс>
                       
        }


        [Route("Cars/List")]//URL-адрес,при переходе на который будет срабатывать функция
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        //функция возвращает,ViewResult - тип данных, который возвращает HTML страничку, List-название
        {
            string _category = category;
            IEnumerable<Car> cars = null;//машины которые нужно отобразить, для компилятора у объекта должно быть значение поэтому: cars = null
            string currCategory = "";
            if (string.IsNullOrEmpty(category))//пустая или не существует
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("X", category, StringComparison.OrdinalIgnoreCase))//если строка category равна electrо; StringComparison.OrdinalIgnoreCase - игнорируем регистр
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("X")).OrderBy(i => i.id);// Equals значит равно(categoryName=Электромобили),OrderBy-сортировка
                    currCategory = "Модель X";
                }
                else if (string.Equals("2", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("2")).OrderBy(i => i.id);
                    currCategory = "Модель 2";
                }
                else if (string.Equals("3", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("3")).OrderBy(i => i.id);
                    currCategory = "Модель 3";
                }
                else if (string.Equals("4", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("4")).OrderBy(i => i.id);
                    currCategory = "Модель 4";
                }
                else if (string.Equals("5", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("5")).OrderBy(i => i.id);
                    currCategory = "Модель 5";
                }
                else if (string.Equals("6", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("6")).OrderBy(i => i.id);
                    currCategory = "Модель 6";
                }
                else if (string.Equals("7", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("7")).OrderBy(i => i.id);
                    currCategory = "Модель 7";
                }
                else if (string.Equals("8", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("8")).OrderBy(i => i.id);
                    currCategory = "Модель 8";
                }
                else if (string.Equals("Z", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Z")).OrderBy(i => i.id);
                    currCategory = "Модель Z";
                }
                else if (string.Equals("M", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("M")).OrderBy(i => i.id);
                    currCategory = "Модель M";
                }
                else if (string.Equals("i", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("i")).OrderBy(i => i.id);
                    currCategory = "Модель i";
                }
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);

            /* 
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;//список со всеми авто
            obj.currCategory = "Автомобили";
            return View(obj);//возвращает страничку со всеми товарами
            */
        }
    }
}
