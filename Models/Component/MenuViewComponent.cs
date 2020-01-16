using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models.Component
{
    public class MenuViewComponent : ViewComponent
    {
        private Context context;
        public MenuViewComponent(Context context)
        {
            this.context = context;
        }
        public IEnumerable<Menu> GetMenus()
        {
            return (context.Menus.Where(x => x.AktifPasif==true).ToList());
        }
        public IViewComponentResult Invoke()
        {
            var a = GetMenus();
            return View(a);
        }
    }
}
