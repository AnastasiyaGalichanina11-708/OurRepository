using System.ComponentModel.DataAnnotations;

namespace NewInstagramApp.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Не указан Email")]
        [RegularExpression (@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
         
        [Required(ErrorMessage = "Не указан пароль")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Длина строки должна быть от 6 до 10 символов")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
         
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}