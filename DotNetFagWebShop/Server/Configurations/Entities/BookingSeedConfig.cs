using DotNetFagWebShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class BookingSeedConfig : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            // add new items here
            builder.HasData(
                new Booking
                {
                    Id = 1,
                    CustomerId = 1,
                    DateIn = DateTime.Now,
                    DateOut = DateTime.Now,
                    VehicleId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                },
                new Booking
                {
                    Id = 2,
                    CustomerId = 2,
                    DateIn = DateTime.Now,
                    DateOut = DateTime.Now,
                    VehicleId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }
            );
        }
    }
}
