
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class SalonRepository : ISalonInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public SalonRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Salon entity)
    {
        _context.Set<Salon>().Add(entity);
    }

    public void AddRange(IEnumerable<Salon> entities)
    {
        _context.Set<Salon>().AddRange(entities);
    }

    public IEnumerable<Salon> Find(Expression<Func<Salon, bool>> expression)
    {
        return _context.Set<Salon>().Where(expression);
    }

    public async Task<IEnumerable<Salon>> GetAllAsync()
    {
        return await _context.Set<Salon>()
        .Include(p => p.Puestos)
        .ToListAsync();
    }

    public async Task<Salon> GetByIdAsync(string id)
    {
        return await _context.Set<Salon>()
        .Include(p => p.Puestos)
        .FirstOrDefaultAsync(p => p.Id_salon == id);
    }

    public void Remove(Salon entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<Salon> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(Salon entity)
    {
        throw new NotImplementedException();
    }
}
