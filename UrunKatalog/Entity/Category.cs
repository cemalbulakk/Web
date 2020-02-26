using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UrunKatalog.Entity
{
    public class Category
    {
        [DisplayName("Kategori")]
        public int Id { get; set; }

        //Data annotations
        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength:20,ErrorMessage = "Kategori Adı en fazla 20 karakter içerebilir.")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}