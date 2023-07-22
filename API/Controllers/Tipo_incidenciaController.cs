using API.Dtos;
using AutoMapper;
using Core.Entities;
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
        if (tipo_incidencia == null) {
            return NotFound();
        }
        return this.mapper.Map<Tipo_incidenciaDto>(tipo_incidencia);
    }
    
    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tipo_incidenciaDto>> Post(Tipo_incidencia tipo_incidencia)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Tipos_incidencias.Add(tipo_incidencia);
        await _UnitOfWork.SaveAsync();
        if (tipo_incidencia == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = tipo_incidencia.Id_tipo_incidencia}, tipo_incidencia);
        //return this.mapper.Map<SalonDto>(salon);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tipo_incidenciaDto>> Put(string id, [FromBody]Tipo_incidencia tipo_incidencia)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (tipo_incidencia == null) {
            return NotFound();
        }
        _UnitOfWork.Tipos_incidencias.Update(tipo_incidencia);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<Tipo_incidenciaDto>(tipo_incidencia);
    }

    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var tipo_incidencia = await _UnitOfWork.Tipos_incidencias.GetByIdAsync(id);
        if (tipo_incidencia == null) {
            return NotFound();
        }
        _UnitOfWork.Tipos_incidencias.Remove(tipo_incidencia);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }

}
