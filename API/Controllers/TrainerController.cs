using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class TrainerController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public TrainerController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<TrainerDto>> Get()
    {
        var trainers = await _UnitOfWork.Trainers.GetAllAsync();
        return this.mapper.Map<List<TrainerDto>>(trainers);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<TrainerDto>> Get(string id)
    {
        var trainer = await _UnitOfWork.Trainers.GetByIdAsync(id);
        if (trainer == null) {
            return NotFound();
        }
        return this.mapper.Map<TrainerDto>(trainer);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TrainerDto>> Post(Trainer trainer)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Trainers.Add(trainer);
        await _UnitOfWork.SaveAsync();
        if (trainer == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = trainer.Id_trainer}, trainer);
        //return this.mapper.Map<SalonDto>(salon);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TrainerDto>> Put(string id, [FromBody]Trainer trainer)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (trainer == null) {
            return NotFound();
        }
        _UnitOfWork.Trainers.Update(trainer);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<TrainerDto>(trainer);
    }

    
    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var trainer = await _UnitOfWork.Trainers.GetByIdAsync(id);
        if (trainer == null) {
            return NotFound();
        }
        _UnitOfWork.Trainers.Remove(trainer);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }
}
