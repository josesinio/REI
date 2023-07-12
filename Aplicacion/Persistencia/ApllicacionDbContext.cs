using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Persistencia;

public class ApllicacionDbContext : DbContext
{
    public ApllicacionDbContext(DbContextOptions<ApllicacionDbContext> opciones)
    : base(opciones)
    {

    }

    public DbSet<Medicion> Mediciones { get; set; }
    public DbSet<Notificacion> Notificaciones { get; set; }
    public DbSet<Falta> Faltas { get; set; }
    public DbSet<Dispositivo> Dispositivos { get; set; }
}
