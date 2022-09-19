using Microsoft.AspNetCore.Identity;
using TestTask.DataAccess.Domain.Abstractions.Interfaces;

namespace TestTask.DataAccess.Domain.Models;

public class Contact : IEntity
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string JobTitle { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string MobilePhone { get; set; }
}