using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Tipo_incidenciaController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public Tipo_incidenciaController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<Tipo_incidenciaDto>> Get()
    {
        var tipos_incidencias = await _UnitOfWork.Tipos_incidencias.GetAllAsync();
        return this.mapper.Map<List<Tipo_incidenciaDto>>(tipos_incidencias);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Tipo_incidenciaDto>> Get(string id)
    {
        var tipo_incidencia = await _UnitOfWork.Tipos_incidencias.GetByIdAsync(id);
        return this.mapper.Map<Tipo_incidenciaDto>(tipo_incidencia);
    }
    
}
