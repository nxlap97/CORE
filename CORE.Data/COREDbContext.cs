using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CORE.Data.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CORE.Data.Extensions;
using CORE.Domain.Models;

namespace CORE.Data
{
    public class COREDbContext : DbContext
    {
        public COREDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { set; get; }
        public DbSet<Blog> Blogs { set; get; }
        public DbSet<BlogCategory> BlogCategories { set; get; }
        public DbSet<MDocument> MDocuments { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<Pricing> Pricings { set; get; }
        public DbSet<Setting> Settings { set; get; }
      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Config
            builder.Entity<Blog>().ToTable("Blogs").HasKey(x => x.Id);
            builder.Entity<Category>().ToTable("Categories").HasKey(x => x.Id);
            builder.Entity<BlogCategory>().ToTable("BlogCategories").HasKey(x => x.Id);
            builder.Entity<MDocument>().ToTable("MDocuments").HasKey(x => x.Id);
            builder.Entity<Customer>().ToTable("Customers").HasKey(x => x.Id);
            builder.Entity<Pricing>().ToTable("Pricings").HasKey(x => x.Id);
            builder.Entity<Setting>().ToTable("Settings").HasKey(x => x.Id);
            #endregion 

            builder.AddConfiguration(new BlogConfiguration());

            base.OnModelCreating(builder);
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<COREDbContext>
    {
        public COREDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var builder = new DbContextOptionsBuilder<COREDbContext>();
            builder.UseSqlServer(connectionString);
            return new COREDbContext(builder.Options);
        }
    }

}
