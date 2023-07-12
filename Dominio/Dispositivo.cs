namespace Dominio;

public class Dispositivo
{
    public int IdDispositivo { get; set; }
    public int NumSerie { get; set; }
    public string Modelo { get; set; }
    public List<Medicion> Mediciones { get; set; }
    public List<Notificacion> Notificaciones { get; set; }
    public List<Falta> Faltas { get; set; }

    public Dispositivo(int idDispositivo, int numSerie, string modelo)
    {
        IdDispositivo = idDispositivo;
        NumSerie = numSerie;
        Modelo = modelo;
        Mediciones = new List<Medicion>();
        Notificaciones = new List<Notificacion>();
        Faltas = new List<Falta>();
    }
}
