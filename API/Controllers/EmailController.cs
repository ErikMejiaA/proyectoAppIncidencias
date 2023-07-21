using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

public class EmailController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public EmailController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    
    public async Task<List<EmailDto>> Get()
    {
        var emails = await _UnitOfWork.Emails.GetAllAsync();
        return this.mapper.Map<List<EmailDto>>(emails);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<EmailDto>> Get(string id)
    {
        var email = await _UnitOfWork.Emails.GetByIdAsync(id);
        return this.mapper.Map<EmailDto>(email);
    }
}
