using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class SoftwareController : BaseApiController
{
     private readonly IUnitOfWorkInterface _UnitOfWork;
     private readonly IMapper mapper;

     public SoftwareController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
     {
          _UnitOfWork = UnitOfWork;
          this.mapper = mapper;
     }

     //METODO GET
     [HttpGet]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<List<SoftwareDto>> Get()
     {
          var softwares = await _UnitOfWork.Softwares.GetAllAsync();
          return this.mapper.Map<List<SoftwareDto>>(softwares);
     }

     //METODO GET POR ID
     [HttpGet("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<SoftwareDto>> Get(string id)
     {
          var software = await _UnitOfWork.Softwares.GetByIdAsync(id);
          if (software == null) {
               return NotFound();
          }
          return this.mapper.Map<SoftwareDto>(software);
     }

     //METODO POST 
     [HttpPost]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<SoftwareDto>> Post(Software software)
     {
          //var area = this.mapper.Map<Area>(areac);
          this._UnitOfWork.Softwares.Add(software);
          await _UnitOfWork.SaveAsync();
          if (software == null) {
               return BadRequest();
          }
          return CreatedAtAction(nameof(Post), new {id = software.Id_software}, software);
          //return this.mapper.Map<SalonDto>(salon);
     }

     //METODO PUT
     [HttpPut("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<SoftwareDto>> Put(string id, [FromBody]Software software)
     {
          //var area = this.mapper.Map<Area>(areac);
          if (software == null) {
               return NotFound();
          }
          _UnitOfWork.Softwares.Update(software);
          await _UnitOfWork.SaveAsync();
          return this.mapper.Map<SoftwareDto>(software);
     }

     //METODO DELETE
     [HttpDelete("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status404NotFound)]
     public async Task<ActionResult> Delete(string id)
     {
          var software = await _UnitOfWork.Softwares.GetByIdAsync(id);
          if (software == null) {
               return NotFound();
          }
          _UnitOfWork.Softwares.Remove(software);
          await _UnitOfWork.SaveAsync();
          return NoContent();
     }
        
}
