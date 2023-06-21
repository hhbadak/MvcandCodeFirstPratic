using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcandCodeFirstPratic.Models
{
    public class Categories
    {
        public int ID { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Bu Alan Boş Bırakılamaz")]
        [StringLength(maximumLength: 100, ErrorMessage = "En fazla 100 karakter girebilirsiniz")]
        public string Name { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}