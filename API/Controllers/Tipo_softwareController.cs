using API.Dtos;
using AutoMapper;
using Core.Entities;
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
        var tipos_softwares = await _UnitOfWork.Tipos_softwares.GetAllAsync();
        return this.mapper.Map<List<Tipo_softwareDto>>(tipos_softwares);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Tipo_softwareDto>> Get(string id)
    {
        var tipo_software = await _UnitOfWork.Tipos_softwares.GetByIdAsync(id);
        if (tipo_software == null) {
            return NotFound();
        }
        return this.mapper.Map<Tipo_softwareDto>(tipo_software);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tipo_softwareDto>> Post(Tipo_software tipo_software)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Tipos_softwares.Add(tipo_software);
        await _UnitOfWork.SaveAsync();
        if (tipo_software == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = tipo_software.Id_tipo_software}, tipo_software);
        //return this.mapper.Map<SalonDto>(salon);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tipo_softwareDto>> Put(string id, [FromBody]Tipo_software tipo_software)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (tipo_software == null) {
            return NotFound();
        }
        _UnitOfWork.Tipos_softwares.Update(tipo_software);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<Tipo_softwareDto>(tipo_software);
    }

    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var tipo_software = await _UnitOfWork.Tipos_softwares.GetByIdAsync(id);
        if (tipo_software == null) {
            return NotFound();
        }
        _UnitOfWork.Tipos_softwares.Remove(tipo_software);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }

}
