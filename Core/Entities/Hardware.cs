
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Hardware
{
    //atributos de la entidad
    [Key]
    public string ? Id_hardware { get; set; }
    public string ? Descripcion { get; set; }

    //llaves foraneas 
    public string ? Id_tipo_hardware { get; set; }
    public string ? Id_puesto { get; set; }
    public string ? Id_categoria { get; set; }

    //definimos las referencias a la entidad
    public Puesto ? Puesto { get; set; }
    public Tipo_hardware ? Tipo_hardware { get; set; }
    public Categoria ? Categoria { get; set; }
    

        
}
