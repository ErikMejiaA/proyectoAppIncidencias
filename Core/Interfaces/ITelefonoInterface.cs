
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ITelefonoInterface
{
    //implentacion de los metodos para el CRUD

    Task<Telefono> GetByIdAsync(string id);
    Task<IEnumerable<Telefono>> GetAllAsync();
    IEnumerable<Telefono> Find(Expression<Func<Telefono, bool>> expression);
    void Add(Telefono entity);
    void AddRange(IEnumerable<Telefono> entities);
    void Remove(Telefono entity);
    void RemoveRange(IEnumerable<Telefono> entities);
    void Update(Telefono entity);

        
}
