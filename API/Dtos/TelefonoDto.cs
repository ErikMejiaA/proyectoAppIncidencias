
namespace API.Dtos;

public class TelefonoDto
{
    //atributos de la entidad
    public string ? Id_telefono { get; set; }
    public string ? Tipo_telefono { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la List<> a la entidad 
    public List<Telefono_trainerDto> ? Telefonos_Trainers { get; set; }
        
}
