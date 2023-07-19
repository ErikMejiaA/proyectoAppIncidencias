
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IEmail_trainerInterface
{
    //implemtacion de los metodos para el CRUD

    Task<Email_trainer> GetByIdAsync(string id);
    IEnumerable<Email_trainer> GetAllAsync();
    IEnumerable<Email_trainer> Find(Expression<Func<Email_trainer, bool>> expression);
    void Add(Email_trainer entity);
    void AddRange(IEnumerable<Email_trainer> entities);
    void Remove(Email_trainer entity);
    void RemoveRange(IEnumerable<Email_trainer> entities);
    void Update(Email_trainer entity);

}
