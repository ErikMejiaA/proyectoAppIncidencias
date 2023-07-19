
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Tipo_hardware
{
    //atributos de la entidad
    [Key]
    public string ? Id_tipo_hardware { get; set; }
    public string ? Nombre_hardware { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection a la entidad 
    public ICollection<Hardware> ? Hardwares { get; set; }    
}
