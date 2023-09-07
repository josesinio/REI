using Aplicacion.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MedicionController : ControllerBase
{
    public AplicacionDbContext contexto { get; }

    public MedicionController (AplicacionDbContext contexto)
    {   
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var mediciones = contexto.Mediciones;
        return Ok(mediciones);
    }


}
