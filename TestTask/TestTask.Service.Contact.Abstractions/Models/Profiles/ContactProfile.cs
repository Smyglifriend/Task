using AutoMapper;

namespace TestTask.Service.Contact.Abstractions.Models.Profiles;

public class ContactProfile : Profile
{
    public ContactProfile()
    {
        CreateMap<ContactDto, DataAccess.Domain.Models.Contact>()
            .ForMember(c => c.DateOfBirth, opt
                => opt.MapFrom(d => DateTime.Parse(d.DateOfBirth)))
            .ReverseMap();
    }
}