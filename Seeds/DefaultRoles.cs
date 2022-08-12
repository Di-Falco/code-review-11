using Microsoft.AspNetCore.Identity;
using Pierre.Constants;
using System.Threading.Tasks;
using Pierre.Models;

namespace Pierre.Seeds
{
  public class DefaultRoles
  {
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
      await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
      await roleManager.CreateAsync(new IdentityRole(Roles.Basic.ToString()));
    }
  }
}