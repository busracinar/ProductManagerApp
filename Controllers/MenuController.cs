using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class MenuController : Controller
    {
        private Context context;
        public readonly IHostEnvironment HostEnvironment;
        public MenuController(Context context, IHostEnvironment hostEnvironment)
        {
            this.context = context;
            HostEnvironment = hostEnvironment;
        }
        public ActionResult Index()
        {
            var a = context.Menus.ToList();
            return View(a);
        }

        // GET: Menu/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Menus.Where(x => x.MenuId == id).FirstOrDefault());
        }

        // GET: Menu/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Menu/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Menu mn, IFormCollection collection)
        {
            try
            {
                Menu menu = new Menu()
                {
                    MenuAdi = mn.MenuAdi,
                    SiraNo = mn.SiraNo,
                    UstMenuId = mn.UstMenuId,
                    AktifPasif = mn.AktifPasif,
                    Controller = mn.Controller,
                    Action = mn.Action,
                    Description = mn.Description
                };
                context.Menus.Add(menu);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: Menu/Edit/5
        public ActionResult Edit(int id)
        {
            var a = context.Menus.Find(id);
            ViewBag.iconlar = new SelectList(context.Menus, "menuID", "desc");
            return View(a);
        }

        // POST: Menu/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Menu mn, int id, IFormCollection collection)
        {
            try
            {
                Menu m = new Menu()
                {
                    MenuId = id,
                    MenuAdi = mn.MenuAdi,
                    SiraNo = mn.SiraNo,
                    UstMenuId = mn.UstMenuId,
                    AktifPasif = mn.AktifPasif,
                    Controller = mn.Controller,
                    Action = mn.Action,
                    Description = mn.Description
                };
                context.Entry(m).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Menu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Menu/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}