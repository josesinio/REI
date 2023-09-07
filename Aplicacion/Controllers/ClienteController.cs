using Aplicacion.Persistencia;
using Aplicacion.ViewModels;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    public AplicacionDbContext contexto { get; }
    public ClienteController(AplicacionDbContext contexto)
    {
        this.contexto = contexto;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var clientes = contexto.Clientes;
        return Ok(clientes);
    }

    [HttpGet("{id: Guid}")]
    public ActionResult Get(Guid id)
    {
        var Cliente = contexto.Clientes.FirstOrDefault(x => x.IdCliente == id);
        return Ok(Cliente);
    }

    [HttpPost]
    public ActionResult Post([FromBody] DispositivoVM dispositivo)
    {
        var NuevoDispositivo = new Dispositivo(new Guid(),dispositivo.NumSerie, dispositivo.Modelo);
        contexto.Add(NuevoDispositivo);
        contexto.SaveChanges();
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPost("/api/Cliente/{idCliente:Guid}/Dispositivo/{idDispositivo:Guid}")]
    public ActionResult AsignarUsuario(Guid idDispositivo, Guid idCliente)
    {
        var dispositivo = contexto.Dispositivos.FirstOrDefault(a => a.IdDispositivo == idDispositivo);
        var cliente = contexto.Clientes.FirstOrDefault(a => a.IdCliente == idCliente);
        cliente.AgregarDispositivos(dispositivo);
        contexto.SaveChanges();
        return Ok("Se asigno dispositivo");
    }



    [HttpPut("{id:Guid}")]
    public ActionResult Put([FromBody] ClienteVM cliente, Guid id)
    {
        var ClienteModificar = contexto.Clientes.FirstOrDefault(x => x.IdCliente == id);

        if (ClienteModificar is null)
            throw new Exception("no existe un cliente con ese Id.");

        ClienteModificar.ModificarCliente(cliente.Email, cliente.Apellido, cliente.Nombre, cliente.Contrasenia);
        contexto.SaveChanges();
        return Ok(ClienteModificar);
    }


    [HttpDelete("{id: Guid}")]
    public ActionResult Delete(Guid id)
    {
        var Clienteborrar = contexto.Clientes.FirstOrDefault(x => x.IdCliente == id);

        if(Clienteborrar is null)
            throw new Exception("No se puede borrar por que no existe dicho cliente.");

        contexto.Clientes.Remove(Clienteborrar);
        contexto.SaveChanges();
        return Ok();
    }
}
