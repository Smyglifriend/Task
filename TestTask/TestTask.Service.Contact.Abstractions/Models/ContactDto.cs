namespace TestTask.Service.Contact.Abstractions.Models;

public class ContactDto
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string JobTitle { get; set; }

    public string DateOfBirth { get; set; }

    public string MobilePhone { get; set; }
}