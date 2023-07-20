using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class AreaController : BaseApiController
{
     private readonly IUnitOfWorkInterface _UnitOfWork;
     
     public AreaController(IUnitOfWorkInterface UnitOfWork)
     {
          _UnitOfWork = UnitOfWork;
     }

     //METODO GET
     [HttpGet]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<ActionResult<IEnumerable<Area>>> Get()
     {
          var areas = await _UnitOfWork.Areas.GetAllAsync();
          return Ok(areas);
     }

     //METODO GET POR ID
     [HttpGet("{id}")]
     [ProducesResponseType(StatusCodes.Status200OK)]
     [ProducesResponseType(StatusCodes.Status400BadRequest)]
     public async Task<IActionResult> Get(string id)
     {
          var area = await _UnitOfWork.Areas.GetByIdAsync(id);
          return Ok(area);
     }
        
}
