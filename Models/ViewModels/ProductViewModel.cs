using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }
        [Display(Name = "Açıklama")]
        public string Desciription { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Stok")]
        public int Stock { get; set; }
        [Display(Name = "Fiyat")]
        public int Price { get; set; }
        [Display(Name = "Resim")]
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }
        [Display(Name = "Kategori")]
        public virtual Category Category { get; set; }
    }
}
