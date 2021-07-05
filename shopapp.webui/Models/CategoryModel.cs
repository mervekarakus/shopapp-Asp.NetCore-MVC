using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using shopapp.entity;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Kategori Alanı Zorunludur.")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Kategori için 5-100 karakterli değer giriniz.")]
        public string Name { get; set; }

         [Required(ErrorMessage ="Url Alanı Zorunludur.")]
        public string Url { get; set; }
        public List<Product> Products { get; set; }
      
         
    }
}