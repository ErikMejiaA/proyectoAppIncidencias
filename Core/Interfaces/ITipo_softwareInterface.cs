
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ITipo_softwareInterface
{
    //implentacion de los metodos para el CRUD

    Task<Tipo_software> GetByIdAsync(string id);
    Task<IEnumerable<Tipo_software>> GetAllAsync();
    IEnumerable<Tipo_software> Find(Expression<Func<Tipo_software, bool>> expression);
    void Add(Tipo_software emtity);
    void AddRange(IEnumerable<Tipo_software> entities);
    void remove(Tipo_software entity);
    void RemoveRange(IEnumerable<Tipo_software> entities);
    void Update(Tipo_software entity);
        
}
