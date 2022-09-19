using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestTask.DataAccess;

public class TestTaskDbContextFactory : IDesignTimeDbContextFactory<TestTaskDbContext>
{
    private const string CONNECTING_STRING = "Server=(LocalDb)\\MSSQLLocalDB;Database=TestTask;Trusted_Connection=True";

    public TestTaskDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TestTaskDbContext>();
        optionsBuilder.UseSqlServer(CONNECTING_STRING);

        return new TestTaskDbContext(optionsBuilder.Options);
    }
}