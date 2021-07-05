using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        //[Required(ErrorMessage = "Doldurulması zorunlu alan.")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Doldurulması zorunlu alan.")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Doldurulması zorunlu alan.")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Doldurulması zorunlu alan.")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Açıklama 5-100 karakter aralığında olmalıdır!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Doldurulması zorunlu alan.")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}