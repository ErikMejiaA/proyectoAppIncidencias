using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CategoriaController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public CategoriaController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
       _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET 
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<List<CategoriaDto>> Get()
    {
         var categorias = await _UnitOfWork.Categorias.GetAllAsync();
         return this.mapper.Map<List<CategoriaDto>>(categorias);
    }

    //METODO GET POR ID
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<CategoriaDto>> Get(string id)
    {
        var categoria = await _UnitOfWork.Categorias.GetByIdAsync(id);
        return this.mapper.Map<CategoriaDto>(categoria);
    }

    //METODO POST 
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoriaDto>> Post(Categoria categoria)
    {
        //var area = this.mapper.Map<Area>(areac);
        this._UnitOfWork.Categorias.Add(categoria);
        await _UnitOfWork.SaveAsync();
        if (categoria == null) {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new {id = categoria.Id_categoria}, categoria);
    }

    //METODO PUT
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CategoriaDto>> Put(string id, [FromBody]Categoria categoria)
    {
        //var area = this.mapper.Map<Area>(areac);
        if (categoria == null) {
            return NotFound();
        }
        _UnitOfWork.Categorias.Update(categoria);
        await _UnitOfWork.SaveAsync();
        return this.mapper.Map<CategoriaDto>(categoria);
    }

    //METODO DELETE
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(string id)
    {
        var categoria = await _UnitOfWork.Categorias.GetByIdAsync(id);
        if (categoria == null) {
            return NotFound();
        }
        _UnitOfWork.Categorias.Remove(categoria);
        await _UnitOfWork.SaveAsync();
        return NoContent();
    }
        
}
