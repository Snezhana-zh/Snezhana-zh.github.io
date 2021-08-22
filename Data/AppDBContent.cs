using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)//Для взаимодействия с базой данных для контекста данных должна быть определена конфигурация подключения. Соответственно, это установка конфигурации подключения+(передать в базовый конструктор)
        {

        }//конструктор

        public DbSet<Car> Car { get; set; }//тип данных <>, как у модели
        public DbSet<Category> Category { get; set; }

        /*в этом файле регистрируем, какие будут таблички, новая модель значит новая табличка*/
        public DbSet<ShopCartItem> ShopCartItem { get; set; }//после добавления новой таблички нужно выполнить миграцию и обновление БД
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}
