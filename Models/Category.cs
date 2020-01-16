using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }
    }
}
