using TestTask.DataAccess.Domain.Abstractions.Interfaces;

namespace TestTask.DataAccess.Domain.Abstractions.Models;

public abstract class BaseEntity : IEntity
{
    public long Id { get; set; }
}