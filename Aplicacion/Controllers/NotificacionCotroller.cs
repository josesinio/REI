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

    [HttpDelete("{string: Mensaje}")]
    public ActionResult Get(string Mensaje)
    {
        var notificacionBorrar = contexto.Notificaciones.FirstOrDefault(x => x.Mensaje == Mensaje);

        if(notificacionBorrar is null)
            throw new Exception("No Existe dicha notificacion.")

        contexto.Notificaciones.remove(notificacion)
        return Ok(notificacion);
    }


}
