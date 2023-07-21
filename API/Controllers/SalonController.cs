using API.Dtos;
using AutoMapper;
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
          return this.mapper.Map<SalonDto>(salon);
     }
        
}
