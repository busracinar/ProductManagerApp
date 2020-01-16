using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ProductApp.Models;
using ProductApp.Models.ViewModels;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        private Context context;
        public readonly IHostEnvironment hostEnvironment;
        public ProductController(Context context, IHostEnvironment hostEnvironment)
        {
            this.context = context;
            this.hostEnvironment = hostEnvironment;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View(context.Products.Include(x => x.Category).ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(context.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            try
            {
                string uniqFileName = null;
                if (productViewModel.Image != null)
                {
                    string uploadsFolder = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot/images");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + productViewModel.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    productViewModel.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Product product = new Product()
                {
                    ProductName = productViewModel.ProductName,
                    Desciription = productViewModel.Desciription,
                    Price = productViewModel.Price,
                    Stock = productViewModel.Stock,
                    CategoryId = productViewModel.CategoryId,
                    Image = uniqFileName
                };
                context.Products.Add(product);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var a = context.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            ViewBag.Categories = new SelectList(context.Categories, "Id", "CategoryName");
            return View(a);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductViewModel productViewModel, int id, IFormCollection collection)
        {
            try
            {
                string uniqFileName = null;
                if (productViewModel.Image != null)
                {
                    string uploadsFolder = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot/images");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + productViewModel.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    productViewModel.Image.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Product product = new Product()
                {
                    Id=id,
                    ProductName = productViewModel.ProductName,
                    Desciription = productViewModel.Desciription,
                    Price = productViewModel.Price,
                    Stock = productViewModel.Stock,
                    CategoryId = productViewModel.CategoryId,
                    Image = uniqFileName
                };
                context.Entry(product).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var productToRemove = context.Products.Find(id);
                context.Products.Remove(productToRemove);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CustomerProductDetail(int id)
        {
            return View(context.Products.Include(x => x.Category).FirstOrDefault(x => x.Id == id));
        }
    }
}