using API.Dtos;
using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Email_trainerController : BaseApiController
{
    private readonly IUnitOfWorkInterface _UnitOfWork;
    private readonly IMapper mapper;

    public Email_trainerController(IUnitOfWorkInterface UnitOfWork, IMapper mapper)
    {
        _UnitOfWork = UnitOfWork;
        this.mapper = mapper;
    }

    //METODO GET
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<List<Email_trainerDto>> Get()
    {
        var emails_trainers = await _UnitOfWork.Emails_trainers.GetAllAsync();
        return this.mapper.Map<List<Email_trainerDto>>(emails_trainers);
    }

    //ETODO GET POR ID
    //hay que mirar como hacer para una tabla que contiene dos Id
}
