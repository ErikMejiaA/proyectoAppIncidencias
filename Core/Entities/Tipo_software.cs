
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Tipo_software
{
    //atributos de la entidad
    [Key]
    public string ? Id_tipo_software { get; set; }
    public string ? Nombre_software { get; set; }
    public string ? Decripcion { get; set; }

    //definimos la ICollection a la entidad 
    public ICollection<Software> ? Softwares { get; set; }
    
    

}