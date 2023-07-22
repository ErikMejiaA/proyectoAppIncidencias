using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Email_trainerController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public Email_trainerController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<Email_trainerDto>> Get()
    {
        var emails_trainers = await _UnitOfWork.Emails_trainers.GetAllAsync();
        return this.mapper.Map<List<Email_trainerDto>>(emails_trainers);
    }

    //METODO GET POR ID
    [HttpGet("{idT}/{idE}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Email_trainerDto>> Get(string idT, string idE)
    {
        var email_trainer = await _UnitOfWork.Emails_trainers.GetByIdAsync(idT, idE);
        if (email_trainer == null) {
            return NotFound();
        }
        return this.mapper.Map<Email_trainerDto>(email_trainer);
    }

    //METODO POST
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Email_trainerDto>> Post(Email_trainer email_trainer)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Emails_trainers.Add(email_trainer);
        await _UnitOfWork.SaveAsync();
        if (email_trainer == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = email_trainer.Id_trainer}, email_trainer);
        //return this.mapper.Map<CategoriaDto>(categoria);
    }

    //METODO PUT
    [HttpPut("{idT}/{idE}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Email_trainerDto>> Put(string idT, string idE, [FromBody]Email_trainer email_trainer)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (email_trainer == null) {
            return NotFound();
        }
        _UnitOfWork.Emails_trainers.Update(email_trainer);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<Email_trainerDto>(email_trainer);
    }

    //METODO DELETE
    [HttpDelete("{idT}/{idE}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string idT, string idE)
    {
        var email_trainer = await _UnitOfWork.Emails_trainers.GetByIdAsync(idT, idE);
        if (email_trainer == null) {
            return NotFound();
        }
        _UnitOfWork.Emails_trainers.Remove(email_trainer);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }

}
