
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface ICategoriaInterface
{
    //implementacion de los metodos para el CRUD

    Task<Categoria> GetByIdAsync(string id);
    Task<IEnumerable<Categoria>> GetAllAsync();
    IEnumerable<Categoria> Find(Expression<Func<Categoria>> expression);
    void Add(Categoria entity);
    void AddRange(IEnumerable<Categoria> entities);
    void Remove(Categoria entyti);
    void RemoveRange(IEnumerable<Categoria> entities);
    void Update(Categoria entity);
        
}
