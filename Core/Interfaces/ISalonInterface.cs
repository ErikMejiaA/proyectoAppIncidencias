
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ISalonInterface
{
    //implementacion de los metodos  para el CRUD

    Task<Salon> GetByIdAsync(string id);
    Task<IEnumerable<Salon>> GetAllAsync();
    IEnumerable<Salon> Find(Expression<Func<Salon, bool>> expression);
    void Add(Salon entity);
    void AddRange(IEnumerable<Salon> entities);
    void Remove(Salon entity);
    void RemoveRange(IEnumerable<Salon> entities);
    void Update(Salon entity);
}
