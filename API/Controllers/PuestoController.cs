using API.Dtos;
using AutoMapper;
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
          return this.mapper.Map<PuestoDto>(puesto);
     }

}
