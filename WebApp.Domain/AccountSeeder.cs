using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp.Domain
{
    public static class AccountSeeder
    {
        public static async void SeedData(IServiceProvider serviceProvider)
        {
            using(var scope = serviceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetService<BumboDbContext>();
                var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                string[] roles = new string[] { "Manager", "Employee" };

                foreach(string role in roles)
                    if(!roleManager.RoleExistsAsync(role).Result) 
                    {
                        await roleManager.CreateAsync(new IdentityRole { Name = role });
                    }

                // create admin account
                var admin = new Account
                {
                    UserName = "admin",
                    Password = "admin123"
                };

                var userManager = scope.ServiceProvider.GetService<UserManager<Account>>();

                if(userManager.FindByNameAsync(admin.UserName).Result == null)
                {
                    IdentityResult result = userManager.CreateAsync(admin, admin.Password).Result;

                    if(result.Succeeded) userManager.AddToRoleAsync(admin, "Manager").Wait();
                }
            }
        }
    }
}