using Microsoft.EntityFrameworkCore;

namespace UdemyMVCTutorial.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

}