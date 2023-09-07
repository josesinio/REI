using Aplicacion.Persistencia;
using Aplicacion.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DispositivoController : ControllerBase
{
    public AplicacionDbContext contexto { get; }
    public DispositivoController(AplicacionDbContext contexto)
    {
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var dispositivos = contexto.Dispositivos;
        return Ok(dispositivos);
    }

    [HttpGet("{id: Guid}")]
    public ActionResult Get(Guid id)
    {
        var dispositivos = contexto.Dispositivos.FirstOrDefault(x => x.IdDispositivo == id);
        return Ok(dispositivos);
    }



    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] DispositivoVM dispositivo, Guid id)
    {
        var DispositivosModificar = contexto.Dispositivos.FirstOrDefault(x => x.IdDispositivo == id);

        if (DispositivosModificar is null)
            throw new Exception("no existe un administrador  con ese Id.");

        DispositivosModificar.Modificar(dispositivo.Modelo, dispositivo.NumSerie);
        contexto.SaveChanges();
        return Ok(DispositivosModificar);
    }


    [HttpDelete("{id: Guid}")]
    public ActionResult Delete(Guid id)
    {
        var dispositivoBorrar = contexto.Dispositivos.FirstOrDefault(x => x.IdDispositivo == id);

        if(dispositivoBorrar is null)
            throw new Exception("No Existe dicho dispostivo.");

        contexto.Dispositivos.Remove(dispositivoBorrar);
        contexto.SaveChanges();
        return Ok();
    }
}
