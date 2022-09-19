using Microsoft.EntityFrameworkCore;
using TestTask.DataAccess.Domain.Extensions;

namespace TestTask.DataAccess;

public class TestTaskDbContext : DbContext
{
    public TestTaskDbContext()
    {

    }

    public TestTaskDbContext(DbContextOptions<TestTaskDbContext> options)
        :base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyEntities();
    }
}