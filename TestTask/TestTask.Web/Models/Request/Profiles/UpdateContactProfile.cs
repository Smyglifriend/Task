using AutoMapper;

namespace TestTask.Web.Models.Request.Profiles;

public class UpdateContactProfiles : Profile
{
    public UpdateContactProfiles()
    {
        CreateMap<ContactVm, ContactDto>();
    }
}