using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartFoods.Web.Data;

namespace SmartFoods.Web;

public static class SeedData
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        // Ensure database is created
        await context.Database.MigrateAsync();

        // Seed a test user if not exists
        var testEmail = "testuser@example.com";
        if (await userManager.FindByEmailAsync(testEmail) == null)
        {
            var user = new ApplicationUser
            {
                UserName = testEmail,
                Email = testEmail,
                FullName = "Test User"
            };
            await userManager.CreateAsync(user, "Test123!");
        }
    }
}
