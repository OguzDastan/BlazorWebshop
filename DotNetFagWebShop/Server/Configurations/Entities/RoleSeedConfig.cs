using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetFagWebShop.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class RoleSeedConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            // add new items here
            builder.HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Administrator",
                    NormalizedName = "ADMIN"
                }
            );
        }
    }
}
