using API.Dtos;
using AutoMapper;
using Core.Entities;
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
        if (telefono == null) {
            return NotFound();
        }
        return this.mapper.Map<TelefonoDto>(telefono);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TelefonoDto>> Post(Telefono telefono)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Telefonos.Add(telefono);
        await _UnitOfWork.SaveAsync();
        if (telefono == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = telefono.Id_telefono}, telefono);
        //return this.mapper.Map<SalonDto>(salon);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TelefonoDto>> Put(string id, [FromBody]Telefono telefono)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (telefono == null) {
            return NotFound();
        }
        _UnitOfWork.Telefonos.Update(telefono);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<TelefonoDto>(telefono);
    }
        
    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var telefono = await _UnitOfWork.Telefonos.GetByIdAsync(id);
        if (telefono == null) {
            return NotFound();
        }
        _UnitOfWork.Telefonos.Remove(telefono);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }
}
