
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IPuestoInterface
{
    //implentacion de los metodos para el CRUD

    Task<Puesto> GetByIdAsync(string id);
    Task<IEnumerable<Puesto>> GetAllAsync();
    IEnumerable<Puesto> Find(Expression<Func<Puesto, bool>> expression);
    void Add(Puesto entity);
    void AddRange(IEnumerable<Puesto> entities);
    void Remove(Puesto entity);
    void RemoveRange(IEnumerable<Puesto> entities);
    void Update(Puesto entity);
}
