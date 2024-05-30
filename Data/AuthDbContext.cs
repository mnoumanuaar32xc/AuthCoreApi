using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace TraningWebApi.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }




        // create roles and user 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // generate guid by C# Interactive command  Guid.NewGuid()
            var readerRoleId = "56b1c4a5-0fa5-4713-bc05-9dfca0086082";
            var writerRoleId = "15d1d7c3-9087-43be-a585-3822805f73e0";

            var roles = new List<IdentityRole>
            { new IdentityRole()
                {
                    Id= readerRoleId,
                Name="Reader".ToUpper(),
                NormalizedName="Reader".ToUpper(),
                ConcurrencyStamp=readerRoleId
                },
                 new IdentityRole()
                 {
                Id= writerRoleId,
                Name="Writer".ToUpper(),
                NormalizedName="Writer".ToUpper(),
                ConcurrencyStamp=writerRoleId
                }


            };

            //seed the roles 
            // when the EF migration runs Roles will be seeds with it.

            builder.Entity<IdentityRole>().HasData(roles);



            // Create a Admin  Users which is act as Admin 

            var adminUserId = "92246535-90b9-4ce2-aedd-14ac92f308be";

            var admin = new IdentityUser()
            {
                Id = adminUserId,
                UserName = "admin.test.com",
                Email = "admin.test.com",
                NormalizedEmail = "admin.test.com".ToUpper(),
                NormalizedUserName = "admin.test.com".ToUpper()
            };
            admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, "Admin@123");

            // seed the admin user into Identity 
            builder.Entity<IdentityUser>().HasData(admin);

            // give Roles  to Admin 
            // We are assign Reader and Writer both Roles


            var adminRoles = new List<IdentityUserRole<string>>()
            {

            new()
            {
            UserId=adminUserId,
            RoleId=readerRoleId,
            },
            new()
            {
            UserId=adminUserId,
            RoleId=writerRoleId,
            }

            };
            // Seed the roles by users
            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);

        }
    }
}
