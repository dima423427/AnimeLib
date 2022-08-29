using AnimeLib.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimeLib.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "",
                Name =  "",
                NormalizedName = ""
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "",
                UserName = "",
                NormalizedUserName = "",
                Email = "",
                NormalizedEmail = "",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "",
                UserId = ""
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid(""),
                CodeWord = "",
                Title = ""
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid(""),
                CodeWord = "",
                Title = ""
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid(""),
                CodeWord = "",
                Title = ""
            });
        }
    }
}
