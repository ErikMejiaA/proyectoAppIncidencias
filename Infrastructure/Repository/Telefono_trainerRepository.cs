
using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class Telefono_trainerRepository : ITelefono_trainerInterface
{
    protected readonly proyectoAppInsidenciasContext _context;

    public Telefono_trainerRepository(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public void Add(Telefono_trainer entity)
    {
        _context.Set<Telefono_trainer>().Add(entity);
    }

    public void AddRange(IEnumerable<Telefono_trainer> entities)
    {
        _context.Set<Telefono_trainer>().AddRange(entities);
    }

    public IEnumerable<Telefono_trainer> Find(Expression<Func<Telefono_trainer, bool>> expression)
    {
        return _context.Set<Telefono_trainer>().Where(expression);
    }

    public async Task<IEnumerable<Telefono_trainer>> GetAllAsync()
    {
        return await _context.Set<Telefono_trainer>().ToListAsync();
    }

    public async Task<Telefono_trainer> GetByIdAsync(string idT, string idTel)
    {
        return await _context.Set<Telefono_trainer>()
        .FirstOrDefaultAsync(p => (p.Id_trainer == idT && p.Id_telefono == idTel));
    }

    public void Remove(Telefono_trainer entity)
    {
        _context.Set<Telefono_trainer>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Telefono_trainer> entities)
    {
        _context.Set<Telefono_trainer>().RemoveRange(entities);
    }

    public void Update(Telefono_trainer entity)
    {
        _context.Set<Telefono_trainer>().Update(entity);
    }
}
