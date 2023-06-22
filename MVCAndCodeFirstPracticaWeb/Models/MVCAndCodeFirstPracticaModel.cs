using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MVCAndCodeFirstPracticaWeb.Models
{
    public partial class MVCAndCodeFirstPracticaModel : DbContext
    {
        public MVCAndCodeFirstPracticaModel()
            : base("name=MVCAndCodeFirstPractica")
        {
        }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
