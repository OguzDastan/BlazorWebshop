using DotNetFagWebShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class ProductSeedConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // add new items here
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Test",
                    Desc = "Test product",
                    CategoryId = 1,
                    Created = DateTime.Now,
                    Price = 2499.95
                }
            );
        }
    }
}
