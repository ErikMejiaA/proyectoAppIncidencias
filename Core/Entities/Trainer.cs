
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Trainer
{
    //atributos de la entidad
    [Key]
    public string ? Id_trainer { get; set; }
    public string ? Nombre_trainer { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection a la entidad
    public ICollection<Incidencia> ? Incidencias { get; set; }
    public ICollection<Telefono_trainer> ? Telefonos_Trainers { get; set; }
    public ICollection<Email_trainer> ? Emails_Trainers { get; set; }
    
    
}
