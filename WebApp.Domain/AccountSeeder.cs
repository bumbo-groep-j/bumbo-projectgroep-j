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

                string[] roles = new string[] { "Manager", "Employee" };

                var roleStore = new RoleStore<IdentityRole>(db);

                foreach(string role in roles)
                    if(!db.Roles.Any(r => r.Name == role))
                    {
                        await roleStore.CreateAsync(new IdentityRole(role));
                    }

                db.SaveChanges();

                // create admin account
                var admin = new Account
                {
                    UserName = "admin",
                    Password = "admin"
                };

                var userManager = scope.ServiceProvider.GetService<UserManager<Account>>();

                if(!db.Users.Any(u => u.UserName == admin.UserName))
                {
                    string[] adminRoles = new string[] { roles[0] };

                    await userManager.CreateAsync(admin, admin.Password);
                    //await userManager.AddToRolesAsync(admin, adminRoles);

                    db.SaveChanges();
                }
            }
        }
    }
}