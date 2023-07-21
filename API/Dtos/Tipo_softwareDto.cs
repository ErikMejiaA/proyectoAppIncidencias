
namespace API.Dtos;

public class Tipo_softwareDto
{
    //atributos de la entidad
    public string ? Id_tipo_software { get; set; }
    public string ? Nombre_software { get; set; }
    public string ? Decripcion { get; set; }

    //definimos la List<> a la entidad 
    public List<SoftwareDto> ? Softwares { get; set; }
        
}
