using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TelefonoController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public TelefonoController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
       _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET 
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<TelefonoDto>> Get()
    {
        var telefonos = await _UnitOfWork.Telefonos.GetAllAsync();
        return this.mapper.Map<List<TelefonoDto>>(telefonos);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<TelefonoDto>> Get(string id)
    {
        var telefono = await _UnitOfWork.Telefonos.GetByIdAsync(id);
        return this.mapper.Map<TelefonoDto>(telefono);
    }
        
}
