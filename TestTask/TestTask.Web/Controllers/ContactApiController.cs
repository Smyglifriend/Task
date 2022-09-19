using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestTask.Service.Contact.Abstractions.Interfaces;
using TestTask.Service.Contact.Abstractions.Models;
using TestTask.Web.Core;
using TestTask.Web.Core.Controller;
using TestTask.Web.Models;
using TestTask.Web.Models.Request;

namespace TestTask.Web.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ContactApiController : BaseWebConroller
{
    private IContactService _contactService;


    public ContactApiController(IMapper mapper, IContactService contactService)
        : base(mapper)
    {
        _contactService = contactService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateContactVm model)
    {
        await _contactService.CreateAsync(_mapper.Map<ContactDto>(model));

        return Ok();
    }

    [Route("{id:long}")]
    [HttpPost]
    public async Task<IActionResult> Delete(long id)
    {
        await _contactService.DeleteAsync(id);

        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateContactVm model)
    {
        await _contactService.UpdateAsync(_mapper.Map<ContactDto>(model));

        return Ok();
    }
}