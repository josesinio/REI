namespace Dominio;
public class Cliente
{
    public string Email { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Contrasenia { get; set; }
    public List<Dispositivo> Dispositivos { get; set; }
    public DateOnly Nacimiento { get; set; }

    public Cliente(string email, string nombre, string apellido, string contrasenia, DateOnly nacimiento)
    {
        Email = email;
        Nombre = nombre;
        Apellido = apellido;
        Contrasenia = contrasenia;
        Nacimiento = nacimiento;
        Dispositivos = new List<Dispositivo>();
    }

}
