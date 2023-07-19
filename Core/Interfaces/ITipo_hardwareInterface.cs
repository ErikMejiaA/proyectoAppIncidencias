
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ITipo_hardwareInterface
{
    //implentacion de los metodos para el CRUD

    Task<Tipo_hardware> GetByIdAsync(string id);
    Task<IEnumerable<Tipo_hardware>> GetAllAsync();
    IEnumerable<Tipo_hardware> Find(Expression<Func<Tipo_hardware, bool>> expression);
    void Add(Tipo_hardware entity);
    void AddRange(IEnumerable<Tipo_hardware> entities);
    void Remove(Tipo_hardware entity);
    void RemoveRange(IEnumerable<Tipo_hardware> entities);
    void Update(Tipo_hardware entity);
        
}
