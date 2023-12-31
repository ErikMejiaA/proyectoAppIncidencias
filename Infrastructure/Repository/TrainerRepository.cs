
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class TrainerRepository : ITrainerInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public TrainerRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Trainer entity)
    {
        _context.Set<Trainer>().Add(entity);
    }

    public void AddRange(IEnumerable<Trainer> entities)
    {
        _context.Set<Trainer>().AddRange(entities);
    }

    public IEnumerable<Trainer> Find(Expression<Func<Trainer, bool>> expression)
    {
        return _context.Set<Trainer>().Where(expression);
    }

    public async Task<IEnumerable<Trainer>> GetAllAsync()
    {
        return await _context.Set<Trainer>()
        .Include(p => p.Incidencias)
        .Include(p => p.Telefonos_Trainers)
        .Include(p => p.Emails_Trainers)
        .ToListAsync();
    }

    public async Task<Trainer> GetByIdAsync(string id)
    {
        return await _context.Set<Trainer>()
        .Include(p => p.Incidencias)
        .Include(p => p.Telefonos_Trainers)
        .Include(p => p.Emails_Trainers)
        .FirstOrDefaultAsync(p => p.Id_trainer == id);
    }

    public void Remove(Trainer entity)
    {
        _context.Set<Trainer>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Trainer> entities)
    {
        _context.Set<Trainer>().RemoveRange(entities);
    }

    public void Update(Trainer entity)
    {
        _context.Set<Trainer>().Update(entity);
    }
}
