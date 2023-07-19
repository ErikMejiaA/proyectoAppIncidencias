
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Telefono
{
    //atributos de la entidad
    [Key]
    public string ? Id_telefono { get; set; }
    public string ? Numero_telefono { get; set; }
    public string ? Tipo_telefono { get; set; }
    public string ? Descripcion { get; set; }

    //definimos la ICollection a la entidad 
    public ICollection<Telefono_trainer> ? Telefonos_Trainers { get; set; }
        
}
