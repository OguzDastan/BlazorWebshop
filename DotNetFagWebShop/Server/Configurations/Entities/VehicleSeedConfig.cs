using DotNetFagWebShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class VehicleSeedConfig : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            // add new items here
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    ColorId = 1,
                    LicensePlateNumber = "AB 123 22",
                    MakeId = 1,
                    ModelId = 1,
                    RentalRate = 1499.95,
                    Year = 2018,
                    Vin = "SADLKASJLKDLJKASDJKASLKJDKAS",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                },
                new Vehicle
                {
                    Id = 2,
                    ColorId = 2,
                    LicensePlateNumber = "ZE 321 44",
                    MakeId = 2,
                    ModelId = 2,
                    RentalRate = 2499.95,
                    Year = 2020,
                    Vin = "OPSAIDPOASFIPPIOOPFASI",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }
            );
        }
    }
}
