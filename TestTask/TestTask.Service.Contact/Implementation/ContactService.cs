using AutoMapper;
using TestTask.DataAccess.Abstractions.Repostories;
using TestTask.Service.Contact.Abstractions.Interfaces;
using TestTask.Service.Contact.Abstractions.Models;

namespace TestTask.Service.Contact.Implementation;

public class ContactService : IContactService
{
    private IUnitOfWork _unitOfWork;
    private IMapper _mapper;


    public ContactService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task CreateAsync(ContactDto dto)
    {
        await _unitOfWork
            .GetReadWriteRepository<DataAccess.Domain.Models.Contact>()
            .SaveAsync(_mapper.Map<DataAccess.Domain.Models.Contact>(dto));
    }

    public async Task<List<ContactDto>> GetAll()
    {
        var result = (await _unitOfWork.GetReadWriteRepository<DataAccess.Domain.Models.Contact>()
            .GetAllAsync())
            .ToList();

        var dto = _mapper.Map<List<ContactDto>>(result);
        return dto;
    }

    public async Task DeleteAsync(long id)
    {
        var contactRepository = _unitOfWork
            .GetReadWriteRepository<DataAccess.Domain.Models.Contact>();
        var contact = await contactRepository.GetFirstOrDefaultAsync(c => c.Id == id);
        if (contact is null)
            throw new Exception("This contact does not exist");
        await contactRepository.RemoveAsync(contact);
    }

    public async Task UpdateAsync(ContactDto dto)
    {
        await _unitOfWork
            .GetReadWriteRepository<DataAccess.Domain.Models.Contact>()
            .SaveAsync(_mapper.Map<DataAccess.Domain.Models.Contact>(dto));
    }
} 