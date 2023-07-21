using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class IncidenciaController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public IncidenciaController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
       _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<List<IncidenciaDto>> Get()
    {
        var incidencias = await _UnitOfWork.Incidencias.GetAllAsync();
        return this.mapper.Map<List<IncidenciaDto>>(incidencias);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IncidenciaDto>> Get(string id)
    {
        var incidencia = await _UnitOfWork.Incidencias.GetByIdAsync(id);
        return this.mapper.Map<IncidenciaDto>(incidencia);
    }
        
}
