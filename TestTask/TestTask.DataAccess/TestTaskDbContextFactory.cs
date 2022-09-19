using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestTask.DataAccess;

public class TrstTaskDbContextFactory : IDesignTimeDbContextFactory<TestTaskDbContext>
{
    private const string CONNECTING_STRING = "Server=(LocalDb)\\MSSQLLocalDB;Database=ModsenTask;Trusted_Connection=True";

    public ModsenTaskDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TestTaskDbContext>();
        optionsBuilder.UseSqlServer(CONNECTING_STRING);

        return new ModsenTaskDbContext(optionsBuilder.Options);
    }
}