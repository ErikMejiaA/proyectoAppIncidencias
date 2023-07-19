
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Salon
{
    //atributos de la entidad 
    [Key]
    public string ? Id_salon { get; set; }
    public string ? Nombre_salon { get; set; }
    public int Numero_puestos { get; set; }
    public string ? Descricion { get; set; }

    //llave foranea 
    public string ? Id_area { get; set; }

    //definimos la referencia a la entidad 
    public Area ?  Area { get; set; }

    //definimos la ICollection a la entidad
    public ICollection<Puesto> ? Puestos { get; set; }

        
}
