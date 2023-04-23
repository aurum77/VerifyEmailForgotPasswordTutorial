using Microsoft.EntityFrameworkCore;
using VerifyEmailForgotPasswordTutorial.Model;

namespace VerifyEmailForgotPasswordTutorial.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=TutorialDb;User Id=SA;Password=SomeSecurePassword123456;TrustServerCertificate=True");
    }

    public DbSet<User> Users => Set<User>();
}
