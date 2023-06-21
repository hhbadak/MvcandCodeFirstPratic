using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcandCodeFirstPratic.Models
{
    public class Suppliers
    {
        public int ID { get; set; }
        [Display(Name = "Tedarikçi Adı")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [StringLength(70, ErrorMessage = "En fazla 70 karakter alabilir")]
        public string CompanyName { get; set; }
        [Display(Name = "Telefon Numarası")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "Telefon Numarası 11 karakter olmalıdır")]
        public string Phone { get; set; }
        public bool status { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}