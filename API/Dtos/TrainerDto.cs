
namespace API.Dtos;

public class TrainerDto
{
    //atributos de la entidad
    public string ? Id_trainer { get; set; }
    public string ? Nombre_trainer { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la List<> a la entidad
    public List<IncidenciaDto> ? Incidencias { get; set; }
    public List<Telefono_trainerDto> ? Telefonos_Trainers { get; set; }
    public List<Email_trainerDto> ? Emails_Trainers { get; set; }
        
}
