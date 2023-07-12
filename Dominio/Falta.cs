namespace Dominio;

public class Falta
{
    public int IdDispositivo { get; set; }
    public string Mensaje { get; set; }
    public Falta(int idDispositivo, string mensaje)
    {
        IdDispositivo = idDispositivo;
        Mensaje = mensaje;
    }
}
