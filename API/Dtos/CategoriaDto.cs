
namespace API.Dtos;

public class CategoriaDto
{
    //atributos de la entidad
    public string ? Id_categoria { get; set; }
    public string ? Nombre_categoria { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la List<> a la entidad 
    public List<SoftwareDto> ? Softwares { get; set; }
    public List<HardwareDto> ? Hardwares { get; set; }
    public List<IncidenciaDto> ? Incidencias { get; set; }
        
}
