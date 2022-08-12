using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Pierre.Seeds;

namespace Pierre.Models
{
  public class PierreContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public PierreContext(DbContextOptions<PierreContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<ApplicationUser>().HasData(new { Id = "1", Email = "admin@pierre.com", Password = "password", EmailConfirmed = true, PhoneNumberConfirmed = true, TwoFactorEnabled = false, LockoutEnabled = false, AccessFailedCount = 0});
      // builder.Entity<RoleClaims>().HasData(new { UserId = 1, RoleId = 1 });

      // DefaultRoles.SeedAsync();
      // var user = new ApplicationUser { UserName = "pierre@admin.com"};
      // IdentityResult result = await userManager.CreateAsync(user, "password");
    }
  }
}