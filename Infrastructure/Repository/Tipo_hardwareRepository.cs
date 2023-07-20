
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class Tipo_hardwareRepository : ITipo_hardwareInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public Tipo_hardwareRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Tipo_hardware entity)
    {
        _context.Set<Tipo_hardware>().Add(entity);
    }

    public void AddRange(IEnumerable<Tipo_hardware> entities)
    {
        _context.Set<Tipo_hardware>().AddRange(entities);
    }

    public IEnumerable<Tipo_hardware> Find(Expression<Func<Tipo_hardware, bool>> expression)
    {
        return _context.Set<Tipo_hardware>().Where(expression);
    }

    public async Task<IEnumerable<Tipo_hardware>> GetAllAsync()
    {
        return await _context.Set<Tipo_hardware>().ToListAsync();
    }

    public async Task<Tipo_hardware> GetByIdAsync(string id)
    {
        return await _context.Set<Tipo_hardware>().FindAsync(id);
    }

    public void Remove(Tipo_hardware entity)
    {
        _context.Set<Tipo_hardware>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Tipo_hardware> entities)
    {
        _context.Set<Tipo_hardware>().RemoveRange(entities);
    }

    public void Update(Tipo_hardware entity)
    {
        _context.Set<Tipo_hardware>().Update(entity);
    }
}
