using Dominio;
using Xunit;

namespace Test;

public class ClienteTest
{
    public Cliente cliente1 { get; set; }
    public Dispositivo Dispositivo1 { get; set; }

    public ClienteTest()
    {
        cliente1 = new Cliente("josesito@gmail.com", "Josesito", "Cruz", "contrasenia",new DateOnly());
        Dispositivo1 = new Dispositivo(new Guid(), 123,"Hypermegasuper");
    }

    [Fact]
    public void AgregarDispositivo()
    {
        cliente1.AgregarDispositivos(Dispositivo1);
        var resultado = 1;

        Assert.Equal(resultado, cliente1.Dispositivos.Count());
    }

    [Fact]
    public void ModificarCliente()
    {
        var email = "julieta@gmail.com";
        var nombre ="julieta";
        var apellido= "Aparicio";
        var contrasenia = "Aparicio en un bar";

        cliente1.ModificarCliente(email,nombre,apellido,contrasenia);

        Assert.Equal(email, cliente1.Email);
        Assert.Equal(nombre, cliente1.Nombre);
        Assert.Equal(apellido, cliente1.Apellido);
        Assert.Equal(contrasenia, cliente1.Contrasenia);
    }
}
