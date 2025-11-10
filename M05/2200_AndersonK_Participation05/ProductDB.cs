using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _2200_AndersonK_Participation05
{
    public partial class ProductDB : DbContext
    {
        public ProductDB()
            : base("name=ProductDB")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Product_Number)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
