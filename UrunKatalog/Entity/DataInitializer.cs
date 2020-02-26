using System.Collections.Generic;
using System.Data.Entity;

namespace UrunKatalog.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name = "Kamera",Description = "Kamera Ürünleri"},
                new Category(){Name = "Bilgisayar",Description = "Bilgisayar Ürünleri"},
                new Category(){Name = "Elektronik",Description = "Elektronik Ürünleri"},
                new Category(){Name = "Telefon",Description = "Telefon Ürünleri"},
                new Category(){Name = "Beyaz Eşya",Description = "Beyaz Eşya Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                //Kamera
                new Product(){Name = "CANON EOS 4000D",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 2299 ,Stock = 100,IsApproved = true ,CategoryId =1 ,IsHome = true,Image = "1.jpg"},
                new Product(){Name = "CANON EOS 5000D",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 3299 ,Stock = 0,IsApproved = true ,CategoryId =1 ,IsHome = true, Image = "2.jpg"},
                new Product(){Name = "CANON EOS 6000D",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 4299 ,Stock = 100,IsApproved = true ,CategoryId =1 ,IsHome = true, Image = "3.jpg"},
                new Product(){Name = "CANON EOS 7000D",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 5299 ,Stock = 100,IsApproved = true ,CategoryId =1 ,IsHome = true, Image = "4.jpg"},
                new Product(){Name = "CANON EOS 8000D",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 6299 ,Stock = 100,IsApproved = true ,CategoryId =1 , Image = "1.jpg"},

                //Bilgisayar
                new Product(){Name = "HP 15-DW0004NT Intel Core i7 8565U 8GB 256GB SSD MX250 Windows 10 Home 15.6'' FHD Taşınabilir Bilgisayar 6EL02EA",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 4500 ,Stock = 100,IsApproved = true ,CategoryId =2 ,IsHome = true, Image = "1.jpg"},
                new Product(){Name = "HP Pavilion 15-CX0032NT Intel Core i7 8750H 16GB 1TB + 256GB SSD GTX1050Ti Windows 10 Home 15.6 FHD Taşınabilir Bilgisayar 5QQ15EA",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 7299 ,Stock = 100,IsApproved = true ,CategoryId =2 ,IsHome = true, Image = "2.jpg"},
                new Product(){Name = "Dell Gaming G315 Intel Core i7 8750H 8GB 1TB + 128GB SSD GTX1050Ti Linux 15.6",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 6285 ,Stock = 100,IsApproved = true ,CategoryId =2 , Image = "3.jpg"},
                new Product(){Name = "Lenovo Ideapad 330-15ICH Intel Core i7 8750H 16GB 1TB + 128GB SSD GTX1050 Freedos ",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 6799 ,Stock = 100,IsApproved = true ,CategoryId =2 , Image = "4.jpg"},
                new Product(){Name = "Lenovo Legion Y530-15ICH Intel Core i7 8750H 16GB 2TB + 256GB SSD GTX1050 Ti Windows 10 Home 15,6",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 6299 ,Stock = 100,IsApproved = true ,CategoryId =2 , Image = "1.jpg"},
                //Elektronik
                new Product(){Name = "Xiaomi Mi Band 4 Akıllı Bileklik Siyah",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 130 ,Stock = 100,IsApproved = true ,CategoryId =3 , Image = "1.jpg"},
                new Product(){Name = "Xiaomi Airdots Pro Bluetooth Spor Kablosuz Kulaklık - IPX4 Suya Dayanıklı - 10 Saate Varan Şarj",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 289 ,Stock = 100,IsApproved = true ,CategoryId =3 ,IsHome = true, Image = "2.jpg"},
                new Product(){Name = "Case 4U 3in1 Lightning + Type-C + Micro USB to USB 2.0 Dayanıklı Naylon Örgü Data ve Şarj Kablosu 1.5m",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 50 ,Stock = 100,IsApproved = true ,CategoryId =3 ,IsHome = true, Image = "3.jpg"},
                new Product(){Name = "Anker PowerWave 7.5 Kablosuz 10W Hızlı Şarj Cihazı Pad Qi Sertifikalı iOS/Android + Soğutma Teknolojisi - A2501",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 119 ,Stock = 100,IsApproved = true ,CategoryId =3 , Image = "4.jpg"},
                new Product(){Name = "Samsung Kablosuz Hızlı Şarj Aleti (Gümüş) EB-U1200CSEGWW",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 359 ,Stock = 100,IsApproved = true ,CategoryId =3 , Image = "1.jpg"},

                //Telefon
                new Product(){Name = "Samsung Galaxy M30s 64 GB",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 2299 ,Stock = 100,IsApproved = true ,CategoryId =4 ,IsHome = true, Image = "1.jpg"},
                new Product(){Name = "Samsung Galaxy M40",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 3130 ,Stock = 100,IsApproved = true ,CategoryId =4 ,IsHome = true, Image = "2.jpg"},
                new Product(){Name = "Huawei P20 Lite 64 GB",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 1900 ,Stock = 100,IsApproved = true ,CategoryId =4 , Image = "3.jpg"},
                new Product(){Name = "Huawei Mate 20 Lite 64 GB",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 1700 ,Stock = 100,IsApproved = true ,CategoryId =4 , Image = "4.jpg"},
                new Product(){Name = "Xiaomi Redmi Note 7",Description = "Öne çıkmanızı sağlayan renkler, ayrıntı ve hoş arka plan bulanıklığı ile benzersiz hikayeleri kolay ve sezgisel biçimde çekip paylaşın.", Price = 3500 ,Stock = 100,IsApproved = true ,CategoryId =4 , Image = "1.jpg"},

                
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}