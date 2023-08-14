using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio;

[Table("Falta")]
public class Falta
{
    [Key]
    [Required]
    public Guid Idfalta { get; set; }
    [Required]
    [StringLength(20)]
    public string Mensaje { get; set; }
    public int IdDispositivo { get; set; }
    public Falta(int idDispositivo, string mensaje)
    {
        IdDispositivo = idDispositivo;
        Mensaje = mensaje;
    }
}
