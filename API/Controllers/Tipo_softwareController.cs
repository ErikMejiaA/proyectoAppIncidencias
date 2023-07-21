using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Tipo_softwareController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public Tipo_softwareController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<Tipo_softwareDto>> Get()
    {
        var tipos_softwares = await _UnitOfWork.Tipos_Softwares.GetAllAsync();
        return this.mapper.Map<List<Tipo_softwareDto>>(tipos_softwares);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Tipo_softwareDto>> Get(string id)
    {
        var tipo_software = await _UnitOfWork.Tipos_Softwares.GetByIdAsync(id);
        return this.mapper.Map<Tipo_softwareDto>(tipo_software);
    }
}
