
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ITrainerInterface
{
    //implentacion de los metodos para el CRUD

    Task<Trainer> GetByIdAsync(string id);
    Task<IEnumerable<Trainer>> GetAllAsync();
    IEnumerable<Trainer> Find(Expression<Func<Trainer, bool>> expression);
    void Add(Trainer entity);
    void AddRange (IEnumerable<Trainer> entities);
    void Remove(Trainer entity);
    void RemoveRange(IEnumerable<Trainer> entities);
    void Update(Trainer entity);
        
}
