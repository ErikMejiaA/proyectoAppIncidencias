
namespace API.Dtos;

public class Tipo_incidenciaDto
{
    //atriutos de la entidada
    public string ? Id_tipo_incidencia { get; set; }
    public string ? Nombre_incidencia_nivel { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la List<> a la entidad
    public List<IncidenciaDto> ? Incidencias { get; set; } 
        
}
