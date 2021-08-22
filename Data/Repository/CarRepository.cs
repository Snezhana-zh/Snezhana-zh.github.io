using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.interfaces;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.Repository
{
    public class CarRepository : IAllCars // наследует всё из данного интерфейса, подключает АppDBContent
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent) //конструктор 
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);//методы расширения Linq ю; в переменную "с" записываем все данные из всех категории. 

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);//все записи, где isFavourite равно true

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId); //первый элемент или по умолчанию, id равен carId      
          
        
    }
}
