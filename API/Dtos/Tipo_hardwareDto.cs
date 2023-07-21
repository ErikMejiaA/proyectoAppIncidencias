
namespace API.Dtos;

public class Tipo_hardwareDto
{
    //atributos de la entidad
    public string ? Id_tipo_hardware { get; set; }
    public string ? Nombre_hardware { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la List<> a la entidad 
    public List<HardwareDto> ? Hardwares { get; set; }  
        
}
