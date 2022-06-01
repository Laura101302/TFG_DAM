using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly ILogger<UsuariosController> _logger;
    private readonly IUsuarioService _usuarioService;

    /// <summary>
    /// Crea UsuarioController
    /// </summary>
    /// <param name="logger">Loggin</param>
    /// <param name="usuarioService">Tratado de Data</param>
    public UsuariosController(ILogger<UsuariosController> logger, IUsuarioService usuarioService)
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }

    /// <summary>
    /// Devuelve todos los usuarios
    /// </summary>
    /// <returns>Devuelve una lista <see cref="UsuarioDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    public ActionResult<UsuarioDTO> Get()
    {
        return Ok(_usuarioService.GetAll());
    }

    /// <summary>
    /// Devuelve un usuario por el Correo Electronico 
    /// </summary>
    /// <param name="CorreoElectronico">El Correo Electronico del usuario</param>
    /// <returns>Devuelve un usuario <see cref="UsuarioDTO"/></returns>
    [HttpGet("{CorreoElectronico}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UsuarioDTO> Get(string CorreoElectronico)
    {
        UsuarioDTO result = _usuarioService.GetByEmail(CorreoElectronico);

        if (result == null)
            return NotFound();

        return Ok(result);

    }

    /// <summary>
    /// Borra un usuario
    /// </summary>
    /// <param name="CorreoElectronico">El Correo Electronico del usuario que se va a borrar</param>
    /// <returns>Devuelve el usuario borrado <see cref="UsuarioDTO"/></returns>
    [HttpDelete("{CorreoElectronico}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UsuarioDTO> Delete(String CorreoElectronico)
    {
        UsuarioDTO result = _usuarioService.GetByEmail(CorreoElectronico);

        if (result == null)
            return NotFound();

        _usuarioService.Delete(CorreoElectronico);

        return Ok(result);

    }


    /// <summary>
    /// Crea un usuario
    /// </summary>
    /// <param name="baseUsuario">El usuario creado <see cref="BaseUsuarioDTO"/></param>
    /// <returns>Devuelve el usuario creado <see cref="UsuarioDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    public ActionResult<UsuarioDTO> Post([FromBody] BaseUsuarioDTO baseUsuario)
    {

        return Ok(_usuarioService.Add(baseUsuario));
    }

    /// <summary>
    /// Modifica un usuario
    /// </summary>
    /// <param name="baseUsuario">El usuario modificado <see cref="BaseUsuarioDTO"/></param>
    /// <param name="CorreoElectronico">El Correo Electronico del usuario modificado</param>
    /// <returns>Devuelve el usuario modificado <see cref="UsuarioDTO"/></returns>
    [HttpPut("{CorreoElectronico}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    public ActionResult<UsuarioDTO> Put([FromBody] BaseUsuarioDTO baseUsuario, string CorreoElectronico)
    {
        return Ok(_usuarioService.Modify(baseUsuario, CorreoElectronico));
    }

}
