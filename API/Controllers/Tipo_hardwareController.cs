using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Tipo_hardwareController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public Tipo_hardwareController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<Tipo_hardwareDto>> Get()
    {
        var tipos_hardwares = await _UnitOfWork.Tipos_Hardwares.GetAllAsync();
        return this.mapper.Map<List<Tipo_hardwareDto>>(tipos_hardwares);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Tipo_hardwareDto>> Get(string id)
    {
        var tipo_hardware = await _UnitOfWork.Tipos_Hardwares.GetByIdAsync(id);
        return this.mapper.Map<Tipo_hardwareDto>(tipo_hardware);
    }

}
