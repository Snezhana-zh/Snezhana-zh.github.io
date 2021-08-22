using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data.interfaces
{
    public interface IAllCars
    {
        //Свойство возвращает все товары(возвращает список<тип данных>)
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }//свойство возвращает все избранные товары

        Car getObjectCar(int carId);//функция 
    }
}
