using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Category.Any())//any это все объекты, если их нет, то добавляем категории
                content.Category.AddRange(Categories.Select(c => c.Value));//AddRange добавляет несклько объектов, из функции выбираем все объеты, брать их значения и записывать как объекты
                    

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "BMW X1",
                        shortDesc = "Двигатель: Бензин"+ "n / " +" Мощность двигателя: 140 л.с;"+ "n / " + "Расход топлива: 6,2 л / 100 км;"+ "n / " + "Разгон(0–100 км / ч): 9,6 с",                        
                        img = "/img/X1.jpg",
                        price = 2520000,
                        isFavourite = false,                       
                        Category = Categories["X"]
                    },
                    new Car
                    {
                        name = "BMW X2",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 192 л.с;" + "n / " + "Расход топлива: 7,1 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 7,4 с",
                        img = "/img/X2.jpg",
                        price = 2680000,
                        isFavourite = false,
                        Category = Categories["X"]
                    },
                    new Car
                    {
                        name = "BMW X3",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 184 л.с;" + "n / " + "Расход топлива: 7,7 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 8,3 с",
                        img = "/img/X3.jpg",
                        price = 44200000,
                        isFavourite = true,
                        Category = Categories["X"]
                    },
                    new Car
                    {
                        name = "BMW X4",
                        shortDesc = "Двигатель: Бензин"+ "n / " +" Мощность двигателя: 340 л.с; "+ "n / " + "Расход топлива: 9,2 л / 100 км; "+ "n / " + "Разгон(0–100 км / ч): 5,5 с",
                        img = "/img/X4.jpg",
                        price = 4750000,
                        isFavourite = true,
                        Category = Categories["X"]
                    },
                    new Car
                    {
                        name = "BMW X5",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/X5.jpg",
                        price = 5900000,
                        isFavourite = false,
                        Category = Categories["X"]
                    },
                    new Car
                    {
                        name = "BMW X6",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/X6.jpg",
                        price = 6950000,
                        isFavourite = false,
                        Category = Categories["X"]
                    },
                    new Car
                    {
                        name = "BMW X7",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/X7.jpg",
                        price = 7560000,
                        isFavourite = false,
                        Category = Categories["X"]
                    },
                    new Car
                    {
                        name = "BMW 2 серии Coupe",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/2 coupe.jpg",
                        price = 3370000,
                        isFavourite = true,
                        Category = Categories["2"]
                    },
                    new Car
                    {
                        name = "BMW 2 серии Gran Coupe",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/2 gran coupe.jpg",
                        price = 2880000,
                        isFavourite = false,
                        Category = Categories["2"]
                    },
                    new Car
                    {
                        name = "BMW 3 серии",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/3.jpg",
                        price = 3220000,
                        isFavourite = false,
                        Category = Categories["3"]
                    },
                    new Car
                    {
                        name = "BMW 4 серии Coupe",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/4 coupe.jpg",
                        price = 3650000,
                        isFavourite = true,
                        Category = Categories["4"]
                    },
                     new Car
                     {
                         name = "BMW 4 серии Gran Coupe",
                         shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                         img = "/img/4 gran coupe.jpg",
                         price = 3730000,
                         isFavourite = true,
                         Category = Categories["4"]
                     },

                    new Car
                    {
                        name = "BMW 4 серии Cabrio",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/4 cabrio.jpg",
                        price = 4210000,
                        isFavourite = true,
                        Category = Categories["4"]
                    },
                    new Car
                    {
                        name = "BMW 5 серии",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/5.jpg",
                        price = 4200000,
                        isFavourite = true,
                        Category = Categories["5"]
                    },
                    new Car
                    {
                        name = "BMW 6 серии GT",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/6.jpg",
                        price = 4990000,
                        isFavourite = true,
                        Category = Categories["6"]
                    },
                    new Car
                    {
                        name = "BMW 7 серии",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/7.jpg",
                        price = 6980000,
                        isFavourite = false,
                        Category = Categories["7"]
                    },
                    new Car
                    {
                        name = "BMW 7 серии Long",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/7 long.jpg",
                        price = 9300000,
                        isFavourite = false,
                        Category = Categories["7"]
                    },
                     new Car
                     {
                         name = "BMW 8 серии Coupe",
                         shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                         img = "/img/8 coupe.jpg",
                         price = 7690000,
                         isFavourite = false,
                         Category = Categories["8"]
                     },
                     new Car
                     {
                         name = "BMW 8 серии Gran Coupe",
                         shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                         img = "/img/8 gran coupe.jpg",
                         price = 8630000,
                         isFavourite = false,
                         Category = Categories["8"]
                     },

                    new Car
                    {
                        name = "BMW 8 серии Cabrio",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/8 cabrio.jpg",
                        price = 7300000,
                        isFavourite = false,
                        Category = Categories["8"]
                    },
                    new Car
                    {
                        name = "BMW Z4 Roadster",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/Z.jpg",
                        price = 4200000,
                        isFavourite = false,
                        Category = Categories["Z"]
                    },
                    new Car
                    {
                        name = "BMW M240i xDrive Coupe",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/M1.jpg",
                        price = 4590000,
                        isFavourite = true,
                        Category = Categories["M"]
                    },
                    new Car
                    {
                        name = "BMW M235i xDrive Gran Coupe",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/M2.jpg",
                        price = 4430000,
                        isFavourite = false,
                        Category = Categories["M"]
                    },
                    new Car
                    {
                        name = "BMW M3 Competition",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/M3.jpg",
                        price = 7370000,
                        isFavourite = true,
                        Category = Categories["M"]
                    },
                    new Car
                    {
                        name = "BMW M4 Competition Coupe",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/M4.jpg",
                        price = 7470000,
                        isFavourite = true,
                        Category = Categories["M"]
                    },
                     new Car
                     {
                         name = "BMW M440i xDrive Cabrio",
                         shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                         img = "/img/M5.jpg",
                         price = 5820000,
                         isFavourite = true,
                         Category = Categories["M"]
                     },
                    new Car
                    {
                        name = "BMW M5",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/M6.jpg",
                        price = 9600000,
                        isFavourite = true,
                        Category = Categories["M"]
                    },
                    new Car
                    {
                        name = "BMW M760Li xDrive",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/M7.jpg",
                        price = 13550000,
                        isFavourite = false,
                        Category = Categories["M"]
                    },
                    new Car
                    {
                        name = "BMW M8 Coupe",
                        shortDesc = "Двигатель: Бензин" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/M8.jpg",
                        price = 11920000,
                        isFavourite = false,
                        Category = Categories["M"]
                    },
                     new Car
                     {
                         name = "BMW iX",
                         shortDesc = "Электромобиль" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                         img = "/img/i1.jpg",
                         price = 8500000,
                         isFavourite = true,
                         Category = Categories["i"]
                     },
                    new Car
                    {
                        name = "BMW i4 M50",
                        shortDesc = "Электромобиль" + "n / " + " Мощность двигателя: 140 л.с;" + "n / " + "Расход топлива: 6,2 л / 100 км;" + "n / " + "Разгон(0–100 км / ч): 9,6 с",
                        img = "/img/i2.jpg",
                        price = 5200000,
                        isFavourite = true,
                        Category = Categories["i"]
                    }
                  );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category; //поле

        public static Dictionary<string, Category> Categories //string - тип ключей в словаре; Category - Тип значений в словаре. это метод!
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName="X"},
                        new Category {categoryName="2"},
                        new Category {categoryName="3"},
                        new Category {categoryName="4"},
                        new Category {categoryName="5"},
                        new Category {categoryName="6"},
                        new Category {categoryName="7"},
                        new Category {categoryName="8"},
                        new Category {categoryName="Z"},
                        new Category {categoryName="M"},
                        new Category {categoryName="i"},
                    };

                    category = new Dictionary<string, Category>(); //выделение памяти под словарь
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);//Add() - Добавляет в словарь пару "ключ-значение", определяемую параметрами key и value.
                }
                return category;

            }
        }        
    }
}
