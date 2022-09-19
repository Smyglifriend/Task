using Task.DataAccess.Domain.Abstractions.Interfaces;

namespace Task.DataAccess.Domain.Abstractions.Models;

public abstract class BaseEntity : IEntity
{
    public long Id { get; set; }
}