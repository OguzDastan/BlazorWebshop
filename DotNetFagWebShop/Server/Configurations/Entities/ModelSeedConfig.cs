using DotNetFagWebShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class ModelSeedConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            // add new items here
            builder.HasData(
                new Model
                {
                    Id = 1,
                    Name = "Aygo",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }, 
                new Model
                {
                    Id = 2,
                    Name = "Yaris",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }, 
                new Model
                {
                    Id = 3,
                    Name = "E200",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                },
                new Model
                {
                    Id = 4,
                    Name = "C200",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                },
                new Model
                {
                    Id = 5,
                    Name = "Octavia",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                },
                new Model
                {
                    Id = 6,
                    Name = "Superb",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }
            );
        }
    }
}
