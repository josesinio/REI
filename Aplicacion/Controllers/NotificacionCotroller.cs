using Aplicacion.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificacionCotroller : ControllerBase
{
    public AplicacionDbContext contexto { get; }
    public NotificacionCotroller(AplicacionDbContext contexto)
    {
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var notificaciones = contexto.Notificaciones;
        return Ok(notificaciones);
    }

    [HttpGet("{string: Mensaje}")]
    public ActionResult Get(string Mensaje)
    {
        var notificacion = contexto.Notificaciones.FirstOrDefault(x => x.Mensaje == Mensaje);
        return Ok(notificacion);
    }

[HttpDelete("{mensaje: string}")]
    public ActionResult Delete(string mensaje)
    {
        var notificacionborrar = contexto.Notificaciones.FirstOrDefault(x => x.Mensaje == mensaje);

        if(notificacionborrar is null)
            throw new Exception("No Existe dicha notificacion.");

        contexto.Notificaciones.Remove(notificacionborrar);
        contexto.SaveChanges();
        return Ok();
    }


}
