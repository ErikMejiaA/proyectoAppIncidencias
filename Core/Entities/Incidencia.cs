
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Incidencia
{
    //atributos de la entidad
    [Key]
    public string ? Id_incidencia { get; set; }
    public string ? Descripcion { get; set; }
    public DateTime Fecha_reporte { get; set; }

    //llaves foraneas
    public string ? Id_tipo_incidencia { get; set; }
    public string ? Id_puesto { get; set; }
    public string ? Id_categoria { get; set; }
    public string ? Id_trainer { get; set; }

    //defimimos las referencias a la entidad
    public Tipo_incidencia ? Tipo_Incidencia { get; set; }
    public Puesto ? Puesto { get; set; }
    public Categoria ? Categoria { get; set; }
    public Trainer ? Trainer { get; set; }
    
    
}
