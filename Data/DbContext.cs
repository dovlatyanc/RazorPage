using Microsoft.EntityFrameworkCore;
using RazorPage.Models;
using System.Collections.Generic;

namespace RazorPage.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
}
