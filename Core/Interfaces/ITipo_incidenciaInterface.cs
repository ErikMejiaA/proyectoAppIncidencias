
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ITipo_incidenciaInterface
{
    //implentacion de los metodos para el CRUD

    Task<Tipo_incidencia> GetByIdAsync(string id);
    Task<IEnumerable<Tipo_incidencia>> GetAllAsync();
    IEnumerable<Tipo_incidencia> Find(Expression<Func<Tipo_incidencia, bool>> expression);
    void Add(Tipo_incidencia entity);
    void AddRange(IEnumerable<Tipo_incidencia> entities);
    void Remove(Tipo_incidencia entity);
    void RemoveRange(IEnumerable<Tipo_incidencia> entities);
    void Update(Tipo_incidencia entity);
        
}
