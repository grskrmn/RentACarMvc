using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identities;
using DataAccess.Concrete.EfCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MvcUI.Infrastructure.Extensions
{
    public static class ApplicationExtension
    {
        public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
        {
             RentACarDbContext context = 
             app.ApplicationServices
             .CreateScope()
             .ServiceProvider
             .GetRequiredService<RentACarDbContext>();

             if(context.Database.GetPendingMigrations().Any())
                    context.Database.Migrate();
        }
        public static async void ConfigureDefaultAdminUserAsync(this IApplicationBuilder app)
        {
            const string adminUser = "Admin";
            const string password = "Admin123";

            UserManager<AppUser> userManager = 
            app.ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<UserManager<AppUser>>();

            RoleManager<IdentityRole> roleManager = 
            app.ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<RoleManager<IdentityRole>>();

            AppUser?  user = await userManager.FindByNameAsync(adminUser);
            if(user is null)
            {
                user = new AppUser
                {
                    FirstName = "Admin",
                    LastName = "AdminUser",
                    Email = "admin@admin.com",
                    UserName = adminUser
                };
                var result = await userManager.CreateAsync(user, password);
                if(!result.Succeeded)
                    throw new Exception("Admin user could not created.");
                var roleResult = await userManager.AddToRolesAsync(user, roleManager.Roles.Select(x => x.Name).ToList());

                if(!roleResult.Succeeded)
                    throw new Exception("System have problem with role defination for Admin.");
            }
        }
    }
}