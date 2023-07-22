using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class Telefono_trainerController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public Telefono_trainerController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<Telefono_trainerDto>> Get()
    {
        var telefonos_trainers = await _UnitOfWork.Telefonos_trainers.GetAllAsync();
        return this.mapper.Map<List<Telefono_trainerDto>>(telefonos_trainers);
    }

    //METODO GET POR ID
    [HttpGet("{idT}/{idTel}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<Telefono_trainerDto>> Get(string idT, string idTel)
    {
        var telefono_trainer = await _UnitOfWork.Telefonos_trainers.GetByIdAsync(idT, idTel);
        if (telefono_trainer == null) {
            return NotFound();
        }
        return this.mapper.Map<Telefono_trainerDto>(telefono_trainer);
    }

    //METODO POST
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Telefono_trainerDto>> Post(Telefono_trainer telefono_trainer)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Telefonos_trainers.Add(telefono_trainer);
        await _UnitOfWork.SaveAsync();
        if (telefono_trainer == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = telefono_trainer.Id_trainer}, telefono_trainer);
        //return this.mapper.Map<CategoriaDto>(categoria);
    }

    
    //METODO PUT
    [HttpPut("{idT}/{idTel}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Telefono_trainerDto>> Put(string idT, string idTel, [FromBody]Telefono_trainer telefono_trainer)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (telefono_trainer == null) {
            return NotFound();
        }
        _UnitOfWork.Telefonos_trainers.Update(telefono_trainer);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<Telefono_trainerDto>(telefono_trainer);
    }

    //METODO DELETE
    [HttpDelete("{idT}/{idTel}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string idT, string idTel)
    {
        var telefono_trainer = await _UnitOfWork.Telefonos_trainers.GetByIdAsync(idT, idTel);
        if (telefono_trainer == null) {
            return NotFound();
        }
        _UnitOfWork.Telefonos_trainers.Remove(telefono_trainer);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }
}
