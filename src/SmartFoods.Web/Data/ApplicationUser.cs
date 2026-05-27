using Microsoft.AspNetCore.Identity;

namespace SmartFoods.Web.Data;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
        = DateTime.UtcNow;
}