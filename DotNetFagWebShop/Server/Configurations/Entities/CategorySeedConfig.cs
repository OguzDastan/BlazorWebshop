using DotNetFagWebShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class CategorySeedConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // add new items here
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Title = "Test"
                },
                new Category
                {
                    Id = 2,
                    Title = "Bukser"
                }
            );
        }
    }
}
