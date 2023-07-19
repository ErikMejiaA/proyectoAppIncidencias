
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Tipo_incidencia
{
    //atriutos de la entidada
    [Key]
    public string ? Id_tipo_incidencia { get; set; }
    public string ? Nombre_incidencia_nivel { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection a la entidad
    public ICollection<Incidencia> ? Incidencias { get; set; } 
    
}
