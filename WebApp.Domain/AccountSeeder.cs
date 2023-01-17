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
            }
        }
    }
}