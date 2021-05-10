using DotNetFagWebShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class MakeSeedConfig : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            // add new items here
            builder.HasData(
                new Make
                {
                    Id = 1,
                    Name = "Toyota",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }, 
                new Make
                {
                    Id = 2,
                    Name = "Mercedes-Benz",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }, 
                new Make
                {
                    Id = 3,
                    Name = "Skoda",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }
            );
        }
    }
}
