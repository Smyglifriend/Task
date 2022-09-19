namespace TestTask.DataAccess;

public class ModsenTaskDbContext : DbContext
{
    public ModsenTaskDbContext()
    {
        
    }
    public ModsenTaskDbContext(DbContextOptions<ModsenTaskDbContext> options)
        :base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyEntities();
    }
}