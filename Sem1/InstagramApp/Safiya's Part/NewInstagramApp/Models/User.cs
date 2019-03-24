using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewInstagramApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; }
        [Display(Name = "Имя и фамилия")]
        public string FirstName { get; set; }
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }
    }
}
