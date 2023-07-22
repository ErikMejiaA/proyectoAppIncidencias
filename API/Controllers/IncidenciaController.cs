using API.Dtos;
using AutoMapper;
using Core.Entities;
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
        if (incidencia == null) {
            return NotFound();
        }
        return this.mapper.Map<IncidenciaDto>(incidencia);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IncidenciaDto>> Post(Incidencia incidencia)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Incidencias.Add(incidencia);
        await _UnitOfWork.SaveAsync();
        if (incidencia == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = incidencia.Id_incidencia}, incidencia);
        //return this.mapper.Map<HardwareDto>(hardware);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IncidenciaDto>> Put(string id, [FromBody]Incidencia incidencia)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (incidencia == null) {
            return NotFound();
        }
        _UnitOfWork.Incidencias.Update(incidencia);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<IncidenciaDto>(incidencia);
    }

    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var incidencia = await _UnitOfWork.Incidencias.GetByIdAsync(id);
        if (incidencia == null) {
            return NotFound();
        }
        _UnitOfWork.Incidencias.Remove(incidencia);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }
        
}
