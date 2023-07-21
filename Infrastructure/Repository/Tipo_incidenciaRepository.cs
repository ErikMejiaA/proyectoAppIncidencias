
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class Tipo_incidenciaRepository : ITipo_incidenciaInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public Tipo_incidenciaRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Tipo_incidencia entity)
    {
        _context.Set<Tipo_incidencia>().Add(entity);
    }

    public void AddRange(IEnumerable<Tipo_incidencia> entities)
    {
        _context.Set<Tipo_incidencia>().AddRange(entities);
    }

    public IEnumerable<Tipo_incidencia> Find(Expression<Func<Tipo_incidencia, bool>> expression)
    {
        return _context.Set<Tipo_incidencia>().Where(expression);
    }

    public async Task<IEnumerable<Tipo_incidencia>> GetAllAsync()
    {
        return await _context.Set<Tipo_incidencia>()
        .Include(p => p.Incidencias)
        .ToListAsync();
    }

    public async Task<Tipo_incidencia> GetByIdAsync(string id)
    {
        return await _context.Set<Tipo_incidencia>()
        .Include(p => p.Incidencias)
        .FirstOrDefaultAsync(p => p.Id_tipo_incidencia == id);
    }

    public void Remove(Tipo_incidencia entity)
    {
        _context.Set<Tipo_incidencia>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Tipo_incidencia> entities)
    {
        _context.Set<Tipo_incidencia>().RemoveRange(entities);
    }

    public void Update(Tipo_incidencia entity)
    {
        _context.Set<Tipo_incidencia>().Update(entity);
    }
}
