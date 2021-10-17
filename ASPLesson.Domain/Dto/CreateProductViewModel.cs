using System;
using System.ComponentModel.DataAnnotations;

namespace ASPLesson.Domain.Dto
{
    public class CreateProductViewModel
    {
        [Required(ErrorMessage = "Укажите название продукта")]
        [MinLength(2, ErrorMessage = "Минимальная длина названия должна быть больше 2 символов")]
        [MaxLength(30, ErrorMessage = "Максимальная длина названия должна быть меньше 30 символов")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Укажите описание продукта")]
        [MinLength(10, ErrorMessage = "Минимальная длина описания должна быть больше 2 символов")]
        [MaxLength(30, ErrorMessage = "Максимальная длина описания должна быть меньше 30 символов")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Укажите стоимость продукта")]
        [Range(0, Double.MaxValue, ErrorMessage = "Некорректный формат цены")]
        public decimal Price { get; set; }
    }
}