using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId = "11cbc596-3709-49b8-ad03-b53afd2e9a0f",
                    UserId = "2685e98b-d5a1-499b-b189-588003018514",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "d979dde0-1f98-4e30-a010-524d41d6b16d",
                    UserId = "eb41f049-e323-46eb-8477-c530801d97bf"
                }
            });
        }
    }
}
