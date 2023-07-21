
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class PuestoRepository : IPuestoInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public PuestoRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Puesto entity)
    {
        _context.Set<Puesto>().Add(entity);
    }

    public void AddRange(IEnumerable<Puesto> entities)
    {
        _context.Set<Puesto>().AddRange(entities);
    }

    public IEnumerable<Puesto> Find(Expression<Func<Puesto, bool>> expression)
    {
        return _context.Set<Puesto>().Where(expression);
    }

    public async Task<IEnumerable<Puesto>> GetAllAsync()
    {
        return await _context.Set<Puesto>()
        .Include(p => p.Hardwares)
        .Include(p => p.Incidencias)
        .Include(p => p.Softwares)
        .ToListAsync();
    }

    public async Task<Puesto> GetByIdAsync(string id)
    {
        return await _context.Set<Puesto>()
        .Include(p => p.Hardwares)
        .Include(p => p.Incidencias)
        .Include(p => p.Softwares)
        .FirstOrDefaultAsync(p => p.Id_puesto == id);
    }

    public void Remove(Puesto entity)
    {
        _context.Set<Puesto>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Puesto> entities)
    {
        _context.Set<Puesto>().RemoveRange(entities);
    }

    public void Update(Puesto entity)
    {
        _context.Set<Puesto>().Update(entity);
    }
}
