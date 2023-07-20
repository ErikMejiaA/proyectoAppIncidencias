
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ITelefono_trainerInterface
{
    //implentacion de los metodos para el CRUD

    Task<Telefono_trainer> GetByIdAsync(string id);
    Task<IEnumerable<Telefono_trainer>> GetAllAsync();
    IEnumerable<Telefono_trainer> Find(Expression<Func<Telefono_trainer, bool>> expression);
    void Add(Telefono_trainer entity);
    void AddRange(IEnumerable<Telefono_trainer> entities);
    void Remove(Telefono_trainer entity);
    void RemoveRange(IEnumerable<Telefono_trainer> entities);
    void Update(Telefono_trainer entity);
        
}
