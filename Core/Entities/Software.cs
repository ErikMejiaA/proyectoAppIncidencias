
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Software
{
    //atributos de la entidad
    [Key]
    public string ? Id_software { get; set; }
    public string ? Descripcion { get; set; }

    //llaves foraneas
    public string ? Id_tipo_software { get; set; }
    public string ? Id_puesto { get; set; }
    public string ? Id_categoria { get; set; }

    //definimos las referencias a la entidad
    public Tipo_software ? Tipo_software { get; set; }
    public Categoria ? Categoria { get; set; }
    public Puesto ? Puesto { get; set; }
        
}
