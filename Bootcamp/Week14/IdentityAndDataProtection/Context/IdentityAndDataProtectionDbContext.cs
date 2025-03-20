using IdentityAndDataProtection.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityAndDataProtection.Context;

public class IdentityAndDataProtectionDbContext : IdentityDbContext<IdentityUser>
{
    public IdentityAndDataProtectionDbContext(DbContextOptions<IdentityAndDataProtectionDbContext> options) :
        base(options)
    {
    }
    public DbSet<UserEntity> Users { get; set; }
}