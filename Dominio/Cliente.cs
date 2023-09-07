using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio;
[Table("Cliente")]
public class Cliente
{
    [Key]
    [Required]
    public Guid IdCliente { get; set; }
    [Required]
    [StringLength(20)]
    public string Email { get; set; }
    [Required]
    [StringLength(20)]
    public string Nombre { get; set; }
    [Required]
    [StringLength(20)]
    public string Apellido { get; set; }
    [Required]
    [StringLength(20)]
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

    public void AgregarDispositivos(Dispositivo dispositivo) =>Dispositivos.Add(dispositivo);

    public void ModificarCliente(string email, string nombre, string apellido, string contrasenia)
    {
        this.Email= email;
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Contrasenia = contrasenia;
    }

    
}
