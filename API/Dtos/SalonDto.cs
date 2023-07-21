
namespace API.Dtos;

public class SalonDto
{
    //atributos de la entidad 
    public string ? Id_salon { get; set; }
    public string ? Nombre_salon { get; set; }
    public int Numero_puestos { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la List<> a la entidad
    public List<PuestoDto> ? Puestos { get; set; }
        
}
