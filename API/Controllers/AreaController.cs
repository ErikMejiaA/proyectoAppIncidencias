
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


public class AreaController : BaseApiController
{
    private readonly proyectoAppInsidenciasContext _context;
    
    public AreaController(proyectoAppInsidenciasContext context)
    {
       _context = context;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Area>>> Get()
    {
         var areas = await _context.Areas.ToListAsync();
         return Ok(areas);
    }
        
}
