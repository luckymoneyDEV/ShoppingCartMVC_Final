﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopingCartEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShoppingCartEntities : DbContext
    {
        public ShoppingCartEntities()
            : base("name=ShoppingCartEntities")
        {
        }
    
         
    
        public virtual DbSet<Band_Product> Band_Product { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PaymenMethod> PaymenMethods { get; set; }
        public virtual DbSet<Product> Products { get; set; }


        public virtual DbSet<Orther> Orthers { get; set; }

        public virtual DbSet<Student> Students { get; set; }
    }
}
