using Aplicacion.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FaltaController : ControllerBase
{
    public AplicacionDbContext contexto { get; }

    public FaltaController (AplicacionDbContext contexto)
    {   
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var faltas = contexto.Faltas;
        return Ok(faltas);
    }

    
    [HttpGet("{mensaje: string}")]
    public ActionResult Get( string mensaje)
    {
        var faltaprimera = contexto.Faltas.LastOrDefault(x => x.Mensaje == mensaje);
        return Ok(faltaprimera);
    }

[HttpDelete("{mensaje: string}")]
    public ActionResult Delete(string mensaje)
    {
        var faltaborrar = contexto.Faltas.FirstOrDefault(x => x.Mensaje == mensaje);

        if(faltaborrar is null)
            throw new Exception("No Existe dicha falta.");

        contexto.Faltas.Remove(faltaborrar);
        contexto.SaveChanges();
        return Ok();
    }
}
