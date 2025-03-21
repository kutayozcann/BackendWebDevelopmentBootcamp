using Jwt.Models;
using Microsoft.EntityFrameworkCore;

namespace Jwt.Context;

public class JwtDbContext : DbContext
{
    public JwtDbContext(DbContextOptions<JwtDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
}