using Microsoft.EntityFrameworkCore;
using UdemyMVCTutorial.Models;

namespace UdemyMVCTutorial.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
}