
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class EmailRepository : IEmailInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public EmailRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Email entity)
    {
        _context.Set<Email>().Add(entity);
    }

    public void AddRange(IEnumerable<Email> entities)
    {
        _context.Set<Email>().AddRange(entities);
    }

    public IEnumerable<Email> Find(Expression<Func<Email, bool>> expression)
    {
        return _context.Set<Email>().Where(expression);
    }

    public async Task<IEnumerable<Email>> GetAllAsync()
    {
        return await _context.Set<Email>()
        .Include(p => p.Emails_Trainers)
        .ToListAsync();
    }

    public async Task<Email> GetByIdAsync(string id)
    {
        return await _context.Set<Email>().FindAsync(id);
    }

    public void Remove(Email entity)
    {
        _context.Set<Email>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Email> entities)
    {
        _context.Set<Email>().RemoveRange(entities);
    }

    public void Update(Email entity)
    {
        _context.Set<Email>().Update(entity);
    }
}
