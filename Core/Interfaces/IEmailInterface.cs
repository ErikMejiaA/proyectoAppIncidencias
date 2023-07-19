
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IEmailInterface
{
    //implementacion de los metodos para el CRUD

    Task<Email> GetByIdAsync(string id);
    Task<IEnumerable<Email>> GetAllAsync();
    IEnumerable<Email> Find(Expression<Func<Email, bool>> expression);
    void Add(Email entity);
    void AddRange(IEnumerable<Email> entities);
    void Remove(Email entity);
    void RemoveRange(IEnumerable<Email> entities);
    void Update(Email entity);
}
