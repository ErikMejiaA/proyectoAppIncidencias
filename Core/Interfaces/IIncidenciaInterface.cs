
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IIncidenciaInterface
{
    //implementacion de los metodos para el CRUD

    Task<Incidencia> GetByIdAsync(string id);
    Task<IEnumerable<Incidencia>> GetAllAsync();
    IEnumerable<Incidencia> Find(Expression<Func<Incidencia, bool>> expression);
    void Add(Incidencia entity);
    void AddRange(IEnumerable<Incidencia> entities);
    void Remove(Incidencia entity);
    void RemoveRange(IEnumerable<Incidencia> entities);
    void Update(Incidencia entity);
        
}
