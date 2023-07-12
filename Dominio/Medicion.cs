namespace Dominio;

public class Medicion
{
    public int IdDispositivo { get; set; }
    public string Unidad { get; set; }
    public int Valor { get; set; }
    public DateTime FechaHora { get; set; }
    public Medicion(int idDispositivo, string unidad, int valor, DateTime fechaHora)
    {
        IdDispositivo = idDispositivo;
        Unidad = unidad;
        Valor = valor;
        FechaHora = fechaHora;
    }
}
