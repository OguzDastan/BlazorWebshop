using DotNetFagWebShop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Configurations.Entities
{
    public class CustomerSeedConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // add new items here
            builder.HasData(
                
                new Customer
                {
                    Id = 1,
                    Address = "Groove Street",
                    Bookings = null,
                    ContactNumber = "42424242",
                    EmailAddress = "g2g@gmai.com",
                    TaxId = "Denmark",
                    Name = "John Johnsen",
                    /*
                    Bookings = new List<Booking> { 
                        new Booking { 
                            Id = 1,
                            
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now,
                            UpdatedBy = "System",
                            CreatedBy = "System"
                        } 
                    },
                    */
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                },
                new Customer
                {
                    Id = 2,
                    Address = "Ringparken 42",
                    Bookings = null,
                    ContactNumber = "33333333",
                    EmailAddress = "ring22@live.com",
                    TaxId = "Denmark",
                    Name = "Bo Bill",
                    /*
                    Bookings = new List<Booking> { 
                        new Booking { 
                            Id = 1,
                            
                            DateCreated = DateTime.Now,
                            DateUpdated = DateTime.Now,
                            UpdatedBy = "System",
                            CreatedBy = "System"
                        } 
                    },
                    */
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System",
                    CreatedBy = "System"
                }
            );
        }
    }
}
