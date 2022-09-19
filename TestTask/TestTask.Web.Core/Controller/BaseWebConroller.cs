using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace TestTask.Web.Core.Controller;

public class BaseWebConroller : Microsoft.AspNetCore.Mvc.Controller
{
    protected readonly IMapper _mapper;


    public BaseWebConroller(IMapper mapper)
    {
        _mapper = mapper;
    }
}