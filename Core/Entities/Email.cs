
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Email
{
    //atributos de la entidad
    [Key]
    public string ? Id_email { get; set; }
    public string ? Email_correo { get; set; }
    public string ? Tipo_email { get; set; }
    public string ? Descripcion { get; set; }

    //definios la ICollection a la entidad
    public ICollection<Email_trainer> ? Emails_Trainers { get; set; }
    
        
}
