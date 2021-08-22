using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage ="Длина имени не менее 3 символов")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Длина фамилии не менее 3 символов")]
        public string surname { get; set; }
        [Display(Name = "Введите адрес")]
        [StringLength(60, MinimumLength = 5)]
        [Required(ErrorMessage = "Длина адреса не менее 5 символов")]
        public string adress { get; set; }
        [Display(Name = "Введите номер")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15, MinimumLength = 3)]
        [Required(ErrorMessage = "Длина номера не менее 3 символов")]
        public string phone { get; set; }
        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, MinimumLength = 10)]
        [Required(ErrorMessage = "Длина email не менее 10 символов")]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]//не отображалось в исходном коде, системное поле
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
