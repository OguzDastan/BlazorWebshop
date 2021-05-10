using DotNetFagWebShop.Server.Configurations.Entities;
using DotNetFagWebShop.Server.Models;
using DotNetFagWebShop.Shared.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFagWebShop.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Make> Makes { get; set; }


        // Seed db with data
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // use entity config classes to seed

            // identity roles
            builder.ApplyConfiguration(new RoleSeedConfig());

            // webshop products
            builder.ApplyConfiguration(new ProductSeedConfig());
            builder.ApplyConfiguration(new CategorySeedConfig());

            // car rental 
            builder.ApplyConfiguration(new BookingSeedConfig());
            builder.ApplyConfiguration(new ColorSeedConfig());
            builder.ApplyConfiguration(new CustomerSeedConfig());
            builder.ApplyConfiguration(new MakeSeedConfig());
            builder.ApplyConfiguration(new ModelSeedConfig());
            builder.ApplyConfiguration(new VehicleSeedConfig());
        }
    }
}
