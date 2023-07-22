
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class HardwareController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public HardwareController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET 
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<List<HardwareDto>> Get()
    {
        var hardwares = await _UnitOfWork.Hardwares.GetAllAsync();
        return this.mapper.Map<List<HardwareDto>>(hardwares);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<HardwareDto>> Get(string id)
    {
        var hardware = await _UnitOfWork.Hardwares.GetByIdAsync(id);
        if (hardware == null) {
            return NotFound();
        }
        return this.mapper.Map<HardwareDto>(hardware);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<HardwareDto>> Post(Hardware hardware)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Hardwares.Add(hardware);
        await _UnitOfWork.SaveAsync();
        if (hardware == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = hardware.Id_hardware}, hardware);
        //return this.mapper.Map<HardwareDto>(hardware);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<HardwareDto>> Put(string id, [FromBody]Hardware hardware)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (hardware == null) {
            return NotFound();
        }
        _UnitOfWork.Hardwares.Update(hardware);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<HardwareDto>(hardware);
    }

    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var hardware = await _UnitOfWork.Hardwares.GetByIdAsync(id);
        if (hardware == null) {
            return NotFound();
        }
        _UnitOfWork.Hardwares.Remove(hardware);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }
}
