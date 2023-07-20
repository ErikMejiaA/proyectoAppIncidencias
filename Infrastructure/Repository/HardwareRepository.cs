
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class HardwareRepository : IHardwareInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public HardwareRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Hardware entity)
    {
        _context.Set<Hardware>().Add(entity);
    }

    public void AddRange(IEnumerable<Hardware> entities)
    {
        _context.Set<Hardware>().AddRange(entities);
    }

    public IEnumerable<Hardware> Find(Expression<Func<Hardware, bool>> expression)
    {
        return _context.Set<Hardware>().Where(expression);
    }

    public async Task<IEnumerable<Hardware>> GetAllAsync()
    {
        return await _context.Set<Hardware>().ToListAsync();
    }

    public async Task<Hardware> GetByIdAsync(string id)
    {
        return await _context.Set<Hardware>().FindAsync(id);
    }

    public void Remove(Hardware entity)
    {
        _context.Set<Hardware>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Hardware> entities)
    {
        _context.Set<Hardware>().RemoveRange(entities);
    }

    public void Update(Hardware entity)
    {
        _context.Set<Hardware>().Update(entity);
    }
}
