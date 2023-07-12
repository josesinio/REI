namespace Dominio;

public class Notificacion
{
    public int IdDispositivo { get; set; }
    public string Mensaje { get; set; }
    public DateTime FechaHora { get; set; }
    public Notificacion(int idDispositivo, string mensaje, DateTime fechaHora)
    {
        IdDispositivo = idDispositivo;
        Mensaje = mensaje;
        FechaHora = fechaHora;
    }
}
