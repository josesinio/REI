using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Persistencia;

public class AplicacionDbContext : DbContext
{
    public AplicacionDbContext(DbContextOptions<AplicacionDbContext> opciones)
    : base(opciones)
    {

    }

    public DbContext<Medicion> Mediciones{ get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Falta> Faltas { get; set; }
    public DbSet<Dispositivo> Dispositivos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
}

public class DbContext<T>
{
}