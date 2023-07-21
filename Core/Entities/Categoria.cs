
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Categoria
{
    //atributos de la entidad
    [Key]
    public string ? Id_categoria { get; set; }
    public string ? Nombre_categoria { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection a la entidad 
    public ICollection<Software> ? Softwares { get; set; }
    public ICollection<Hardware> ? Hardwares { get; set; }
    public ICollection<Incidencia> ? Incidencias { get; set; }

        
}
