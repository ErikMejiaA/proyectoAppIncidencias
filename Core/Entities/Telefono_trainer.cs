
namespace Core.Entities;

public class Telefono_trainer
{
     //atributos de la entidad
    //llave primaria compuestas
    public string ? Id_trainer { get; set; }
    public string ? Id_telefono { get; set; }

    //definimos las referencias a la entidad
    public Trainer ? Trainer { get; set; }
    public Telefono ? Telefono { get; set; }
    

        
}
