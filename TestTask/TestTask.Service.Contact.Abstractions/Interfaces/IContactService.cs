using TestTask.Service.Contact.Abstractions.Models;

namespace TestTask.Service.Contact.Abstractions.Interfaces;

public interface IContactService
{
    Task CreateAsync(ContactDto dto);

    Task<List<ContactDto>> GetAll();

    Task DeleteAsync(long id);

    Task UpdateAsync(ContactDto dto);
}