using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

public class EmailController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public EmailController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    
    public async Task<List<EmailDto>> Get()
    {
        var emails = await _UnitOfWork.Emails.GetAllAsync();
        return this.mapper.Map<List<EmailDto>>(emails);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<EmailDto>> Get(string id)
    {
        var email = await _UnitOfWork.Emails.GetByIdAsync(id);
        return this.mapper.Map<EmailDto>(email);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EmailDto>> Post(Email email)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Emails.Add(email);
        await _UnitOfWork.SaveAsync();
        if (email == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = email.Id_email}, email);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EmailDto>> Put(string id, [FromBody]Email email)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (email == null) {
            return NotFound();
        }
        _UnitOfWork.Emails.Update(email);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<EmailDto>(email);
    }

    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var email = await _UnitOfWork.Emails.GetByIdAsync(id);
        if (email == null) {
            return NotFound();
        }
        _UnitOfWork.Emails.Remove(email);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }
}
