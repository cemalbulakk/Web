using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrunKatalog.Models
{
    public class ShippingDetails
    {
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adres Başlığını Giriniz.")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen Adresi Giriniz.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen Şehrinizi Giriniz.")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen Semt Giriniz.")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen Mahallenizi Giriniz.")]
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }


    }
}