﻿using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.EntityFramework.Mappings
{
    internal class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.ProductId);

            Property(x=>x.ProductId).HasColumnName("ProductID");
            Property(x=>x.CategoryId).HasColumnName("CategoryID");
            Property(x=>x.ProductName).HasColumnName("ProductName");
            Property(x=>x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            Property(x=>x.UnitPrice).HasColumnName("UnitPrice");
        }
    }
}
