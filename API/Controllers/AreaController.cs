using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class AreaController : BaseApiController
{
     private readonly IUnitOfWorkInterface _UnitOfWork;
     private readonly IMapper mapper;

     public AreaController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
     {

          _UnitOfWork = UnitOfWork;
          this.mapper = mapper;
     }

     //METODO GET
     [HttpGet]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<List<AreaDto>> Get()
     {
          var areas = await _UnitOfWork.Areas.GetAllAsync();
          return this.mapper.Map<List<AreaDto>>(areas);
     }

     //METODO GET POR ID
     [HttpGet("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<AreaDto>> Get(string id)
     {
          var area = await _UnitOfWork.Areas.GetByIdAsync(id);
          return this.mapper.Map<AreaDto>(area);
     }

     //METODO POST 
     [HttpPost]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<AreaDto>> Post(Area area)
     {
          this._UnitOfWork.Areas.Add(area);
          await _UnitOfWork.SaveAsync();
          if (area == null) {
               return BadRequest();
          }
          //return CreatedAtAction(nameof(Post), new {id = area.Id_area}, area);
          return CreatedAtAction(nameof(Post), new {id = area.Id_area}, area);
     }

        
}
