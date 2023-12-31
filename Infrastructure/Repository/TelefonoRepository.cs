
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class TelefonoRepository : ITelefonoInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public TelefonoRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Telefono entity)
    {
        _context.Set<Telefono>().Add(entity);
    }

    public void AddRange(IEnumerable<Telefono> entities)
    {
        _context.Set<Telefono>().AddRange(entities);
    }

    public IEnumerable<Telefono> Find(Expression<Func<Telefono, bool>> expression)
    {
        return _context.Set<Telefono>().Where(expression);
    }

    public async Task<IEnumerable<Telefono>> GetAllAsync()
    {
        return await _context.Set<Telefono>()
        .Include(p => p.Telefonos_Trainers)
        .ToListAsync();
    }

    public async Task<Telefono> GetByIdAsync(string id)
    {
        return await _context.Set<Telefono>()
        .Include(p => p.Telefonos_Trainers)
        .FirstOrDefaultAsync(p => p.Id_telefono == id);
    }

    public void Remove(Telefono entity)
    {
        _context.Set<Telefono>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Telefono> entities)
    {
        _context.Set<Telefono>().RemoveRange(entities);
    }

    public void Update(Telefono entity)
    {
        _context.Set<Telefono>().Update(entity);
    }
}
