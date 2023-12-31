
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class AreaRepository : IAreaInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public AreaRepository(proyectoAppInsidenciasContext context )
    {
        _context = context;
    }

    public void Add(Area entity)
    {
        _context.Set<Area>().Add(entity);
    }

    public void AddRange(IEnumerable<Area> entities)
    {
        _context.Set<Area>().AddRange(entities);
    }

    public IEnumerable<Area> Find(Expression<Func<Area, bool>> expression)
    {
        return _context.Set<Area>().Where(expression);
    }

    public async Task<IEnumerable<Area>> GetAllAsync()
    {
        return await _context.Set<Area>()
        .Include(p => p.Salones)
        .ToListAsync();
    }

    public async Task<Area> GetByIdAsync(string id)
    {
        return await _context.Set<Area>()
        .Include(p => p.Salones)
        .FirstOrDefaultAsync(p => p.Id_area == id);
    }

    public void Remove(Area entity)
    {
        _context.Set<Area>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Area> entities)
    {
        _context.Set<Area>().RemoveRange(entities);
    }
    
    public void Update(Area entity)
    {
        _context.Set<Area>().Update(entity);
    }
}
