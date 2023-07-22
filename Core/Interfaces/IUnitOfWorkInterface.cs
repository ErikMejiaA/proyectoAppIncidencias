
namespace Core.Interfaces;

public interface IUnitOfWorkInterface
{
    //implementamos cada un de la interfces creadas
    IAreaInterface Areas { get; set; }
    ICategoriaInterface Categorias { get; set; }
    IEmail_trainerInterface Emails_trainers { get; set; }
    IEmailInterface Emails { get; set; }
    IHardwareInterface Hardwares { get; set; }
    IIncidenciaInterface Incidencias { get; set; }
    IPuestoInterface Puestos { get; set; }
    ISalonInterface Salones { get; set; }
    ISoftwareInterface Softwares { get; set; }
    ITelefono_trainerInterface Telefonos_trainers { get; set; }
    ITelefonoInterface Telefonos { get; set; }
    ITipo_hardwareInterface Tipos_hardwares { get; set; }
    ITipo_incidenciaInterface Tipos_incidencias { get; set; }
    ITipo_softwareInterface Tipos_softwares { get; set; }
    ITrainerInterface Trainers { get; set; }

    Task<int> SaveAsync();
        
}
