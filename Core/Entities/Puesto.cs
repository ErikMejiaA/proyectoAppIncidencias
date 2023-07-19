
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Puesto
{
    //atributos de la entidad
    [Key]
    public string ? Id_puesto { get; set; }
    public string ? Nombre_puesto { get; set; }

    //llave foranea
    public string ? Id_salon { get; set; }

    //definimos la ICollection a la entidad 
    public ICollection<Hardware> ? Hardwares { get; set; }
    public ICollection<Incidencia> ? Incidencias { get; set; }
    public ICollection<Software> ? Softwares { get; set; }

    //difinimo la referencia a la entidad 
    public Salon ? Salon { get; set; }
        
}
