using System;
using CompanySite.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompanySite.Domain
{
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        { 

        }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "85011dea-56dd-4ced-950a-329ec93bc990",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "cc2b02a4-65ae-47a6-86a9-a02a4e4b3836",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "e.mail@gmail.com",
                NormalizedEmail = "E.MAIL@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "randomWord"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            { 
                RoleId = "85011dea-56dd-4ced-950a-329ec93bc990",
                UserId = "cc2b02a4-65ae-47a6-86a9-a02a4e4b3836"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("a7da92d3-495f-40b0-b986-4f0204ba6ea0"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("8b4ae5ff-d5da-417a-85f4-5c6ae24c8815"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("73485868-82b5-4c0e-9d8d-5580fe9bfd55"),
                CodeWord = "PageServices",
                Title = "Услуги"
            });
        }
    }
}
