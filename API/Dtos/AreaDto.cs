
namespace API.Dtos;

public class AreaDto
{
    //atributos de la entidad 
    public string ? Id_area { get; set; }
    public string ? Nombre_area { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la List<> a la entidad
    public List<SalonDto> ? Salones { get; set; }
        
}
