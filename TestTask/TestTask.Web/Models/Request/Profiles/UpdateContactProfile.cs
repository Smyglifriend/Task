using AutoMapper;
using TestTask.Service.Contact.Abstractions.Models;

namespace TestTask.Web.Models.Request.Profiles;

public class UpdateContactProfile : Profile
{
    public UpdateContactProfile()
    {
        CreateMap<UpdateContactVm, ContactDto>();
    }
}