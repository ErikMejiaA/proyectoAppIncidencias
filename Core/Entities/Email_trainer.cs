
namespace Core.Entities;

public class Email_trainer
{
    //atributos de la entidad 
    //llave primaria compuesta
    public string ? Id_trainer { get; set; }
    public string ? Id_email { get; set; }

    //definimos las referencias a la entidad 
    public Trainer ? Trainer { get; set; }
    public Email ? Email { get; set; }
      
}
