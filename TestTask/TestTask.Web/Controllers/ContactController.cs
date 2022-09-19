using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestTask.Service.Contact.Abstractions.Interfaces;
using TestTask.Web.Core;
using TestTask.Web.Core.Controller;
using TestTask.Web.Models;
using TestTask.Web.Models.Request;
using TestTask.Web.Models.Response;

namespace TestTask.Web.Controllers;

public class ContactController : BaseWebConroller
{
    private IContactService _contactService;


    public ContactController(IMapper mapper, IContactService contactService)
        :base(mapper)
    {
        _contactService = contactService;
    }


    [HttpGet]
    public async Task<IActionResult> DisplayAllContacts()
    {
        var contacts = await _contactService.GetAll();
        var result = _mapper.Map<List<ContactVm>>(contacts);

        return View(result);
    }
}