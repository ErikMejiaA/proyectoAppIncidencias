
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class Tipo_softwareRepository : ITipo_softwareInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public Tipo_softwareRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Tipo_software entity)
    {
        _context.Set<Tipo_software>().Add(entity);
    }

    public void AddRange(IEnumerable<Tipo_software> entities)
    {
        _context.Set<Tipo_software>().AddRange(entities);
    }

    public IEnumerable<Tipo_software> Find(Expression<Func<Tipo_software, bool>> expression)
    {
        return _context.Set<Tipo_software>().Where(expression);
    }

    public async Task<IEnumerable<Tipo_software>> GetAllAsync()
    {
        return await _context.Set<Tipo_software>()
        .Include(p => p.Softwares)
        .ToListAsync();
    }

    public async Task<Tipo_software> GetByIdAsync(string id)
    {
        return await _context.Set<Tipo_software>()
        .Include(p => p.Softwares)
        .FirstOrDefaultAsync(p => p.Id_tipo_software == id);
    }

    public void Remove(Tipo_software entity)
    {
        _context.Set<Tipo_software>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Tipo_software> entities)
    {
        _context.Set<Tipo_software>().RemoveRange(entities);
    }

    public void Update(Tipo_software entity)
    {
        _context.Set<Tipo_software>().Update(entity);
    }
}
