
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles;

public class MappingProfiles : Profile
{
      public MappingProfiles()
    {
        CreateMap<Area, AreaDto>().ReverseMap();
        CreateMap<Salon, SalonDto>().ReverseMap();
        CreateMap<Puesto, PuestoDto>().ReverseMap();
        CreateMap<Categoria, CategoriaDto>().ReverseMap();
        CreateMap<Email_trainer, Email_trainerDto>().ReverseMap();
        CreateMap<Email, EmailDto>().ReverseMap();
        CreateMap<Hardware, HardwareDto>().ReverseMap();
        CreateMap<Incidencia, IncidenciaDto>().ReverseMap();
        CreateMap<Software, SoftwareDto>().ReverseMap();
        CreateMap<Telefono_trainer, Telefono_trainerDto>().ReverseMap();
        CreateMap<Telefono, TelefonoDto>().ReverseMap();
        CreateMap<Tipo_hardware, Tipo_hardwareDto>().ReverseMap();
        CreateMap<Tipo_incidencia, Tipo_incidenciaDto>().ReverseMap();
        CreateMap<Tipo_software, Tipo_softwareDto>().ReverseMap();
        CreateMap<Trainer, TrainerDto>().ReverseMap();
        
    }
        
}
