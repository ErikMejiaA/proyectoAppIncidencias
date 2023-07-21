
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWorkInterface, IDisposable
{
    //variable context
    private readonly proyectoAppInsidenciasContext _context;

    //genermos las vaiables de cada repositorio creado
    private AreaRepository ? _areas;
    private CategoriaRepository ? _categorias;
    private Email_trainerRepository ? _emails_trainers;
    private EmailRepository ? _emails;
    private HardwareRepository ? _hardwares;
    private IncidenciaRepository ? _incidencias;
    private PuestoRepository ? _puestos;
    private SalonRepository ? _salones;
    private SoftwareRepository ? _softwares;
    private Telefono_trainerRepository ? _telefonos_trainers;
    private TelefonoRepository ? _telefonos;
    private Tipo_hardwareRepository ? _tipos_hardwares;
    private Tipo_incidenciaRepository ? _tipos_incidencias;
    private Tipo_softwareRepository ? _tipos_softwares;
    private TrainerRepository ? _trainers;

    //constructor
    public UnitOfWork(proyectoAppInsidenciasContext context)
    {
        _context = context;
    }

    public IAreaInterface Areas 
    { 
        get 
        {
            if (_areas == null) {
                _areas = new AreaRepository(_context);
            }
            return _areas;
        } 

        set
        {
            if(_areas == null) {
                _areas = new AreaRepository(_context);
            }
        } 
    }

    public ICategoriaInterface Categorias 
    { 
        get
        {
            if (_categorias == null) {
                _categorias = new CategoriaRepository(_context);
            }
            return _categorias;
        }

        set 
        {
            if (_categorias == null) {
                _categorias = new CategoriaRepository(_context);
            }
        } 
        
    }

    public IEmail_trainerInterface Emails_trainers 
    { 
        get 
        {
            if (_emails_trainers == null) {
                _emails_trainers = new Email_trainerRepository(_context);
            }
            return _emails_trainers;
        }

        set 
        {
            if (_emails_trainers == null) {
                _emails_trainers = new Email_trainerRepository(_context);
            }
        }
    }

    public IEmailInterface Emails 
    { 
        get
        {
            if (_emails == null) {
                _emails = new EmailRepository(_context);
            }
            return _emails;
        } 

        set 
        {
            if (_emails == null) {
                _emails = new EmailRepository(_context);
            }
        } 
    }

    public IHardwareInterface Hardwares 
    { 
        get
        {
            if (_hardwares == null) {
                _hardwares = new HardwareRepository(_context);
            }
            return _hardwares;
        }

        set 
        {
            if (_hardwares == null) {
                _hardwares = new HardwareRepository(_context);
            }
        }
    }

    public IIncidenciaInterface Incidencias 
    { 
        get
        {
            if (_incidencias == null) {
                _incidencias = new IncidenciaRepository(_context);
            }
            return _incidencias;
        }
        
        set
        {
            if (_incidencias == null) {
                _incidencias = new IncidenciaRepository(_context);
            }
        }
    }
    public IPuestoInterface Puestos 
    { 
        get
        {
            if (_puestos == null) {
                _puestos = new PuestoRepository(_context);
            }
            return _puestos;
        }

        set
        {
            if (_puestos == null) {
                _puestos = new PuestoRepository(_context);
            }
        }
    }

    public ISalonInterface Salones 
    { 
        get 
        {
            if (_salones == null) {
                _salones = new SalonRepository(_context);
            }
            return _salones;
        }

        set
        {
             if (_salones == null) {
                _salones = new SalonRepository(_context);
            }
        }
    
    }

    public ISoftwareInterface Softwares 
    { 
        get
        {
            if (_softwares == null) {
                _softwares = new SoftwareRepository(_context);
            }
            return _softwares;
        }

        set
        {
            if (_softwares == null) {
                _softwares = new SoftwareRepository(_context);
            }
        }
    }

    public ITelefono_trainerInterface Telefonos_trainers 
    { 
        get
        {
            if (_telefonos_trainers == null) {
                _telefonos_trainers = new Telefono_trainerRepository(_context);
            }
            return _telefonos_trainers;
        }

        set
        {
            if (_telefonos_trainers == null) {
                _telefonos_trainers = new Telefono_trainerRepository(_context);
            }
        }
    }

    public ITelefonoInterface Telefonos 
    { 
        get
        {
            if (_telefonos == null) {
                _telefonos = new TelefonoRepository(_context);
            }
            return _telefonos;
        } 

        set
        {
            if (_telefonos == null) {
                _telefonos = new TelefonoRepository(_context);
            }
        }
    }

    public ITipo_hardwareInterface Tipos_Hardwares 
    { 
        get
        {
            if (_tipos_hardwares == null) {
                _tipos_hardwares = new Tipo_hardwareRepository(_context);
            }
            return _tipos_hardwares;
        } 

        set 
        {
             if (_tipos_hardwares == null) {
                _tipos_hardwares = new Tipo_hardwareRepository(_context);
            }
        } 
    }
    
    public ITipo_incidenciaInterface Tipos_incidencias 
    {
        get
        {
            if (_tipos_incidencias == null) {
                _tipos_incidencias = new Tipo_incidenciaRepository(_context);
            }
            return _tipos_incidencias;
        }

        set 
        {
             if (_tipos_incidencias == null) {
                _tipos_incidencias = new Tipo_incidenciaRepository(_context);
            }
        }
    }

    public ITipo_softwareInterface Tipos_Softwares 
    {
        get
        {
            if (_tipos_softwares == null) {
                _tipos_softwares = new Tipo_softwareRepository(_context);
            }
            return _tipos_softwares;
        } 

        set
        {
            if (_tipos_softwares == null) {
            _tipos_softwares = new Tipo_softwareRepository(_context);
            }
        } 
    }

    public ITrainerInterface Trainers 
    { 
        get
        {
            if (_trainers == null) {
                _trainers = new TrainerRepository(_context);
            }
            return _trainers;
        } 

        set
        {
            if (_trainers == null) {
                _trainers = new TrainerRepository(_context);
            }
        } 
    }

    public void Dispose()
    {
        _context.Dispose(); //destruir el contexto si no se esta Utilizando, liberar memoria
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync(); //guardar los datos enviados por el metodo Post, Delete, Put en la Db

    }
}
