using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio;
[Table("Medicion")]
public class Medicion
{
    [Key]
    [Required]
    public Guid IdMedicion { get; set; }
    [Required]
    [StringLength(20)]
    public string Unidad { get; set; }
    [Required]
    public int Valor { get; set; }
    [Required]
    public DateTime FechaHora { get; set; }
    public int IdDispositivo { get; set; }
    public Medicion(int idDispositivo, string unidad, int valor, DateTime fechaHora)
    {
        IdDispositivo = idDispositivo;
        Unidad = unidad;
        Valor = valor;
        FechaHora = fechaHora;
    }
}
