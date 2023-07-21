
namespace API.Dtos;

public class PuestoDto
{
    //atributos de la entidad
    public string ? Id_puesto { get; set; }
    public string ? Nombre_puesto { get; set; }

    //definimos la list<> a la entidad 
    public List<HardwareDto> ? Hardwares { get; set; }
    public List<IncidenciaDto> ? Incidencias { get; set; }
    public List<SoftwareDto> ? Softwares { get; set; }
        
}
