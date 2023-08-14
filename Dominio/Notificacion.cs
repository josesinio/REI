using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio;

[Table("Notificacion")]
public class Notificacion
{
    [Key]
    [Required]
    public Guid IdNotificacion { get; set; }
    [Required]
    [StringLength(20)]
    public string Mensaje { get; set; }
    [Required]
    public DateTime FechaHora { get; set; }
    public int IdDispositivo { get; set; }
    public Notificacion(int idDispositivo, string mensaje, DateTime fechaHora)
    {
        IdDispositivo = idDispositivo;
        Mensaje = mensaje;
        FechaHora = fechaHora;
    }
}
