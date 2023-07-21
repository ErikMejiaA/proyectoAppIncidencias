using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class Telefono_trainerController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public Telefono_trainerController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<Telefono_trainerDto>> Get()
    {
        var telefonos_trainers = await _UnitOfWork.Telefonos_trainers.GetAllAsync();
        return this.mapper.Map<List<Telefono_trainerDto>>(telefonos_trainers);
    }

    //METODO GET POR ID
    //falta imlementar x que no tiene dos llaves primarias cumpuestas 
}
