using AutoMapper;
using TestTask.Service.Contact.Abstractions.Models;

namespace TestTask.Web.Models.Response.Profiles;

public class ContactProfile : Profile
{
    public ContactProfile()
    {
        CreateMap<ContactDto, ContactVm>();
    }
}