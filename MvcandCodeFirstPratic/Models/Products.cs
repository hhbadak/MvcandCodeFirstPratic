using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace MvcandCodeFirstPratic.Models
{
    public class Products
    {
        [Display(Name = "Ürün ID")]
        public int ID { get; set; }
        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Ürün adı boş bırakılamaz")]
        [StringLength(maximumLength: 75, ErrorMessage = "Bu alan en fazla 75 karakter alabilir")]
        public string Name { get; set; }
        [Display(Name = "Kategori")]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Categories Categories { get; set; }
        public int SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public virtual Suppliers Suppliers { get; set; }
        public double UnitPrice { get; set; }
        public bool Status { get; set; }
    }
}