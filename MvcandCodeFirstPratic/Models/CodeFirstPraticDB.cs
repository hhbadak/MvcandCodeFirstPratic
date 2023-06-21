using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MvcandCodeFirstPratic.Models
{
    public partial class CodeFirstPraticDB : DbContext
    {
        public CodeFirstPraticDB()
            : base("name=CodeFirstPraticDB")
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
