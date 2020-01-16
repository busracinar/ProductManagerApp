using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        [Display(Name = "Menü Adı")]
        public string MenuAdi { get; set; }
        [Display(Name = "Menü İkon")]
        public string Description { get; set; }
        [Display(Name = "Üst Menü Id")]
        public int UstMenuId { get; set; }
        [Display(Name = "Sıra No")]
        public int SiraNo { get; set; }
        [Display(Name = "Aktif Mi?")]
        public bool AktifPasif { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
