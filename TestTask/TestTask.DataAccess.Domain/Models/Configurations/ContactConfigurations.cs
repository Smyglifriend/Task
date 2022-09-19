using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestTask.DataAccess.Domain.Models.Configurations;

public class ContactConfigurations : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder
            .Property(c => c.Name)
            .IsRequired();
        builder
            .HasIndex(u => u.Name)
            .IsUnique();

        builder
            .Property(c => c.JobTitle)
            .IsRequired();
        
        builder
            .Property(c => c.MobilePhone)
            .IsRequired();
        builder
            .HasIndex(u => u.MobilePhone)
            .IsUnique();
        
        builder
            .Property(c => c.DateOfBirth)
            .IsRequired();
    }
}