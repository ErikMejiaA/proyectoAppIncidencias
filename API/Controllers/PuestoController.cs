using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class PuestoController : BaseApiController
{
     private readonly IUnitOfWorkInterface _UnitOfWork;
     private readonly IMapper mapper;

     public PuestoController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
     {
          _UnitOfWork = UnitOfWork;
          this.mapper = mapper;
     }

     //METODO GET
     [HttpGet]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<List<PuestoDto>> Get()
     {
          var puestos = await _UnitOfWork.Puestos.GetAllAsync();
          return this.mapper.Map<List<PuestoDto>>(puestos);
     }

     //METODO GET POR ID
     [HttpGet("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<PuestoDto>> Get(string id)
     {
          var puesto = await _UnitOfWork.Puestos.GetByIdAsync(id);
          if (puesto == null) {
               return NotFound();
          }
          return this.mapper.Map<PuestoDto>(puesto);
     }

     //METODO POST 
     [HttpPost]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<PuestoDto>> Post(Puesto puesto)
     {
          //var area = this.mapper.Map<Area>(areac);
          this._UnitOfWork.Puestos.Add(puesto);
          await _UnitOfWork.SaveAsync();
          if (puesto == null) {
               return BadRequest();
          }
          return CreatedAtAction(nameof(Post), new {id = puesto.Id_puesto}, puesto);
          //return this.mapper.Map<HardwareDto>(hardware);
     }

     //METODO PUT
     [HttpPut("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<PuestoDto>> Put(string id, [FromBody]Puesto puesto)
     {
          //var area = this.mapper.Map<Area>(areac);
          if (puesto == null) {
               return NotFound();
          }
          _UnitOfWork.Puestos.Update(puesto);
          await _UnitOfWork.SaveAsync();
          return this.mapper.Map<PuestoDto>(puesto);
     }

     //METODO DELETE
     [HttpDelete("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     public async Task<ActionResult> Delete(string id)
     {
          var puesto = await _UnitOfWork.Puestos.GetByIdAsync(id);
          if (puesto == null) {
               return NotFound();
          }
          _UnitOfWork.Puestos.Remove(puesto);
          await _UnitOfWork.SaveAsync();
          return NoContent();
     }

}
