using AutoMapper;
using TestTask.Service.Contact.Abstractions.Models;

namespace TestTask.Web.Models.Request.Profiles;

public class ContactProfile : Profile
{
    public ContactProfile()
    {
        CreateMap<CreateContactVm, ContactDto>()
            .ReverseMap();
    }
}