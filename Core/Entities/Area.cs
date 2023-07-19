
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Area
{
    //atributos de la entidad 
    [Key]
    public string ? Id_area { get; set; }
    public string ? Nombre_area { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection a la entidad
    public ICollection<Salon> ? Salones { get; set; }

}
