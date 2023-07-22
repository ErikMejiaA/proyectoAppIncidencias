using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class SalonController : BaseApiController
{
     private readonly IUnitOfWorkInterface _UnitOfWork;
     private readonly IMapper mapper;

     public SalonController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
     {
          _UnitOfWork = UnitOfWork;
          this.mapper = mapper;
     }

     //METODO GET
     [HttpGet]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<List<SalonDto>> Get()
     {
          var salones = await _UnitOfWork.Salones.GetAllAsync();
          return this.mapper.Map<List<SalonDto>>(salones);
     }

     //METODO GET POR ID
     [HttpGet("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<SalonDto>> Get(string id)
     {
          var salon = await _UnitOfWork.Salones.GetByIdAsync(id);
          if (salon == null) { 
               return NotFound();
          }
          return this.mapper.Map<SalonDto>(salon);
     }

     //METODO POST 
     [HttpPost]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<SalonDto>> Post(Salon salon)
     {
          //var area = this.mapper.Map<Area>(areac);
          this._UnitOfWork.Salones.Add(salon);
          await _UnitOfWork.SaveAsync();
          if (salon == null) {
               return BadRequest();
          }
          return CreatedAtAction(nameof(Post), new {id = salon.Id_salon}, salon);
          //return this.mapper.Map<SalonDto>(salon);
     }

     //METODO PUT
     [HttpPut("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<SalonDto>> Put(string id, [FromBody]Salon salon)
     {
          //var area = this.mapper.Map<Area>(areac);
          if (salon == null) {
               return NotFound();
          }
          _UnitOfWork.Salones.Update(salon);
          await _UnitOfWork.SaveAsync();
          return this.mapper.Map<SalonDto>(salon);
     }

     //METODO DELETE
     [HttpDelete("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     public async Task<ActionResult> Delete(string id)
     {
          var salon = await _UnitOfWork.Salones.GetByIdAsync(id);
          if (salon == null) {
               return NotFound();
          }
          _UnitOfWork.Salones.Remove(salon);
          await _UnitOfWork.SaveAsync();
          return NoContent();
     }

        
}
