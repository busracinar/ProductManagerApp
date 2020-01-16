using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Categories.Any())
                {
                    return;
                }
                context.Categories.AddRange(
                    new Category() { CategoryName = "Kamera"},
                    new Category() { CategoryName = "Bilgisayar"},
                    new Category() { CategoryName = "Elektronik"},
                    new Category() { CategoryName = "Telefon"},
                    new Category() { CategoryName = "Beyaz Eşya"},
                    new Category() { CategoryName = "Televizyon"}

                    );
                if (context.Products.Any())
                {
                    return;
                }
                context.Products.AddRange(
                    new Product() { ProductName = "Sony FDR-AX53 4K Ultra HD Video Kamera", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 6329, Stock = 1200, CategoryId = 1, Image= "145.jpg" },
                    new Product() { ProductName = "Evervox EVR-S1 1.3MP Wi-Fi Akıllı Kamera", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 229, Stock = 600, CategoryId = 1, Image = "9870841380914.jpg" },
                    new Product() { ProductName = "Sony HXR-MC2500 Profesyonel Video Kamera", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 8083, Stock = 0, CategoryId = 1, Image = "A7III-2870-1-600x666.jpg" },
                    new Product() { ProductName = "Sony FDR-AX100 4K Ultra HD Video Kamera", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 8028, Stock = 300, CategoryId = 1, Image = "sony-hxr-mc2500-profesyonel-kamera-z.jpg" },
                    new Product() { ProductName = "Sony HXR-NX100 Full HD Profesyonel NXCAM Video Kamera", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 11493, Stock = 300, CategoryId = 1, Image = "Sony-HXR---NX200-4K-Profesyonel-Video-Kamera-resim-17206.jpg" },

                    new Product() { ProductName = "Lenovo V330 81AX00DQTX Dizüstü Bilgisayar", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 3499, Stock = 2000, CategoryId = 2, Image = "img.jpg" },
                    new Product() { ProductName = "Lenovo IdeaPad 330 81D200PBTX AMD Ryzen 5 2500U 8GB 256GBSSD 2GB Radeon540 15.6 FHD Freedos Notebook", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 3149, Stock = 200, CategoryId = 2, Image = "dell-inspiron-3585-fhdbr5f8256c-ryzen-5-2500u-8-gb-256-gb-ssd-radeon-vega-8-15-6-full-hd-z.jpg" },
                    new Product() { ProductName = "HP 7AM62EA Dizüstü Bilgisayar", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 5569, Stock = 5, CategoryId = 2, Image = "5nt-7dq77ea-1.png" },
                    new Product() { ProductName = "Acer AN515-52-54ZN NH.Q3LEY.012 Dizüstü Bilgisayar", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 5079, Stock = 50, CategoryId = 2, Image = "47599248.jpg" },
                    new Product() { ProductName = "Casper Excalibur G900.9750-BE60X Dizüstü Bilgisayar", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 8499, Stock = 380, CategoryId = 2, Image = "10246768197682.jpg" },

                    new Product() { ProductName = "Singer Brilliance 6180 Elektronik Dikiş Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 759, Stock = 400, CategoryId = 3, Image = "537322186z.jpg" },
                    new Product() { ProductName = "Fakir Ranger Elektronik Elektrikli Süpürge", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 569, Stock = 30, CategoryId = 3, Image = "fakir-range-electronic-900-w-z.jpg" },
                    new Product() { ProductName = "Tabanca Havya 40 Watt Havya Lehim Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 24, Stock = 700, CategoryId = 3, Image = "61HOWL.jpg" },
                    new Product() { ProductName = "Sewing FH201 Elektronik Pedallı Mini Dikiş Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 119, Stock = 1200, CategoryId = 3, Image = "images.jpg" },
                    new Product() { ProductName = "Ultrasonik Riddex Plus Elektronik Fare Ve Haşere Kovucu", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 16, Stock = 90, CategoryId = 3, Image = "riddex.jpg" },

                    new Product() { ProductName = "HUAWEI P Smart 2019 Akıllı Telefon Mavi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1688, Stock = 1000, CategoryId = 4, Image = "huwei p smart.jpg" },
                    new Product() { ProductName = "SAMSUNG Galaxy A70 Akıllı Telefon Beyaz", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2783, Stock = 6000, CategoryId = 4, Image = "SAMSUNG Galaxy A70 Akıllı Telefon Beyaz.jpg" },
                    new Product() { ProductName = "K6 Note 3/32GB Akıllı Telefon Gri Lenovo Türkiye Garantili", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 911, Stock = 500, CategoryId = 4, Image = "sdgsd.jpg" },
                    new Product() { ProductName = "HUAWEI Y5 2019 Akıllı Telefon Modern Siyah ", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1200, Stock = 750, CategoryId = 4, Image = "huawei-y5-2019-16gb-siyah-z.jpg" },
                    new Product() { ProductName = "Apple iPhone 6S 32 GB Rose Gold Akıllı Telefon", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2999, Stock = 10, CategoryId = 4, Image = "Apple iPhone 6S 32 GB Rose Gold Akıllı Telefon.jpg" },

                    new Product() { ProductName = "Nexon BM 501 Bulaşık Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1099, Stock = 900, CategoryId = 5, Image = "altus-al-403-m-a-3-programli-z.jpg" },
                    new Product() { ProductName = "Vestel BM-500 Retro Bulaşık Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2399, Stock = 1500, CategoryId = 5, Image = "electrolux-esf6630rok-a-6-programli-z.jpg" },
                    new Product() { ProductName = "Altus AL 403 M Bulaşık Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1187, Stock = 450, CategoryId = 5, Image = "m_altus-al-435-x-1.jpg" },
                    new Product() { ProductName = "Electrolux ESF5533LOW Bulaşık Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 2398, Stock = 0,CategoryId = 5, Image = "Nexon BM 501 Bulaşık Makinesi.jpg" },
                    new Product() { ProductName = "Altus AL 435 XI Bulaşık Makinesi", Desciription = "Belirtilen tüm özellikler bilgilendirme amaçlı olup, farklı nitelikte özellikler olabilir.", Price = 1819, Stock = 2500, CategoryId = 5, Image = "vestel-bm-500-a-kirmizi-5-programli-z.jpg" }
                    );
                context.SaveChanges();
            }
        }
    }
}
