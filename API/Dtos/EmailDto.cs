
namespace API.Dtos;

public class EmailDto
{
    //atributos de la entidad
    public string ? Id_email { get; set; }
    public string ? Tipo_email { get; set; }
    public string ? Descripcion { get; set; }

    //definios la List<> a la entidad
    public List<Email_trainerDto> ? Emails_Trainers { get; set; }
        
}
