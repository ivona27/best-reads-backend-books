using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Auth
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("TBL_USERS"); //AspNetUsers
            builder.Entity<IdentityRole>().ToTable("TBL_ROLES"); //AspNetRoles
            builder.Entity<IdentityUserRole<string>>().ToTable("TBL_USER_ROLE"); //AspNetUserRole
            builder.Entity<IdentityUserClaim<string>>().ToTable("TBL_USER_CLAIM"); //AspNetUserClaim
            builder.Entity<IdentityUserLogin<string>>().ToTable("TBL_USER_LOGIN"); //AspNetUserLogin
            builder.Entity<IdentityRoleClaim<string>>().ToTable("TBL_ROLE_CLAIM"); //AspNetRoleClaim
            builder.Entity<IdentityUserToken<string>>().ToTable("TBL_USER_TOKEN"); //AspNetUserToken
        }
    }
}
