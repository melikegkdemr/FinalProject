using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext //ismini context vermem context olduğu anlamına gelmez Entity framework ile gelen DbContext classını bağladık.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //bu method senin projenin hangi veritabanı ile ilişkili onu gösterir
        {
            optionsBuilder.UseSqlServer(@"Server =(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); //sql serverimizin nerede olduğunu söylüyoruz
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } //
        public DbSet<Customer> Customers { get; set; }


    }
}
