
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class Email_trainerRepository : IEmail_trainerInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public Email_trainerRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Email_trainer entity)
    {
        _context.Set<Email_trainer>().Add(entity);
    }

    public void AddRange(IEnumerable<Email_trainer> entities)
    {
        _context.Set<Email_trainer>().AddRange(entities);
    }

    public IEnumerable<Email_trainer> Find(Expression<Func<Email_trainer, bool>> expression)
    {
        return _context.Set<Email_trainer>().Where(expression);
    }

    public async Task<IEnumerable<Email_trainer>> GetAllAsync()
    {
        return await _context.Set<Email_trainer>().ToListAsync();
    }

    public async Task<Email_trainer> GetByIdAsync(string id)
    {
        return await _context.Set<Email_trainer>().FindAsync(id);
    }

    public void Remove(Email_trainer entity)
    {
        _context.Set<Email_trainer>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Email_trainer> entities)
    {
        _context.Set<Email_trainer>().RemoveRange(entities);
    }

    public void Update(Email_trainer entity)
    {
        _context.Set<Email_trainer>().Update(entity);
    }

}
