using API.Dtos;
using AutoMapper;
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
          return this.mapper.Map<SoftwareDto>(software);
     }
        
}
