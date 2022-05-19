using Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Core.Domain.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<Role>().HasData(new Role
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
                Description = "Administrator role"
            },
             new Role
             {
                 Id = new Guid("aa6f243a-5cbc-42d5-a432-08d83b5447b1"),
                 Name = "User",
                 NormalizedName = "USER",
                 Description = "Member"
             });

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminId,
                LastName = "root",
                FisrtName = "root",
                AvataUrl = "/upload/avatar/avatar.jpg",
                UserName = "root",
                Email = "root@gmail.com",
                PhoneNumber = "0327547475",
                Address = "Que Loc - Nong Son - Quang Nam",
                PasswordHash = hasher.HashPassword(null, "Abc123!@#"),
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
