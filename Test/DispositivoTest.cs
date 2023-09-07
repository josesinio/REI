using Dominio;
using Xunit;

namespace Test;

public class DispositivoTest
{
    public Dispositivo dispositivo1 { get; set; }
    public DispositivoTest()
    {
        dispositivo1 = new Dispositivo(new Guid(), 1434, "Supermega");
    }
    
    [Fact]
    public void Modificar()
    {
        var numSerie = 123;
        var modelo ="superduper";
    
        dispositivo1.Modificar(modelo, numSerie);

        Assert.Equal(numSerie, dispositivo1.NumSerie);
        Assert.Equal(modelo, dispositivo1.Modelo);

    }

}
