using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Dominio;
[Table("Dispositvo")]
public class Dispositivo
{
    [Key]
    [StringLength(20)]
    public Guid IdDispositivo { get; set; }
    [Required]
    public int NumSerie { get; set; }
    [Required]
    [StringLength(20)]
    public string Modelo { get; set; }
    public List<Medicion> Mediciones { get; set; }
    public List<Notificacion> Notificaciones { get; set; }
    public List<Falta> Faltas { get; set; }

    public Dispositivo(Guid idDispositivo, int numSerie, string modelo)
    {
        IdDispositivo = idDispositivo;
        NumSerie = numSerie;
        Modelo = modelo;
        Mediciones = new List<Medicion>();
        Notificaciones = new List<Notificacion>();
        Faltas = new List<Falta>();
    }

    public void Modificar (string modelo, int numSerie)
    { 
        this.Modelo =modelo;
        this.NumSerie = numSerie;
    }
    


}
