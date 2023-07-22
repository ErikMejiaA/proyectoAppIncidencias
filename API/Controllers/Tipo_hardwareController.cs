using API.Dtos;
using AutoMapper;
using Core.Entities;
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
        var tipos_hardwares = await _UnitOfWork.Tipos_hardwares.GetAllAsync();
        return this.mapper.Map<List<Tipo_hardwareDto>>(tipos_hardwares);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Tipo_hardwareDto>> Get(string id)
    {
        var tipo_hardware = await _UnitOfWork.Tipos_hardwares.GetByIdAsync(id);
        if (tipo_hardware == null) {
            return NotFound();
        }
        return this.mapper.Map<Tipo_hardwareDto>(tipo_hardware);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tipo_hardwareDto>> Post(Tipo_hardware tipo_hardware)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Tipos_hardwares.Add(tipo_hardware);
        await _UnitOfWork.SaveAsync();
        if (tipo_hardware == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = tipo_hardware.Id_tipo_hardware}, tipo_hardware);
        //return this.mapper.Map<SalonDto>(salon);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Tipo_hardwareDto>> Put(string id, [FromBody]Tipo_hardware tipo_hardware)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (tipo_hardware == null) {
            return NotFound();
        }
        _UnitOfWork.Tipos_hardwares.Update(tipo_hardware);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<Tipo_hardwareDto>(tipo_hardware);
    }

    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var tipo_hardware = await _UnitOfWork.Tipos_hardwares.GetByIdAsync(id);
        if (tipo_hardware == null) {
            return NotFound();
        }
        _UnitOfWork.Tipos_hardwares.Remove(tipo_hardware);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }

}
