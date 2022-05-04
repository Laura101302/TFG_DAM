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
    /// It creates a usuarioController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="usuarioService">used for dealing with the usuario data</param>
    public UsuariosController(ILogger<UsuariosController> logger, IUsuarioService usuarioService)
    {
        _logger = logger;
        _usuarioService = usuarioService;
    }

    /// <summary>
    /// Returns all the usuarios
    /// </summary>
    /// <returns>Returns a list of <see cref="UsuarioDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    public ActionResult<UsuarioDTO> Get()
    {
        return Ok(_usuarioService.GetAll());
    }

    /// <summary>
    /// It returns a usuario by id 
    /// </summary>
    /// <param name="CorreoElectronico">the email of the usuario</param>
    /// <returns>Returns a usuario <see cref="UsuarioDTO"/></returns>
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
    /// it deletes a usuario
    /// </summary>
    /// <param name="CorreoElectronico">the email of the usuario that is going to be deleted</param>
    /// <returns>Returns the deleted usuario <see cref="UsuarioDTO"/></returns>
    [HttpDelete("{CorreoElectronico}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UsuarioDTO> Delete(string CorreoElectronico)
    {
        UsuarioDTO result = _usuarioService.GetByEmail(CorreoElectronico);

        if (result == null)
            return NotFound();

        _usuarioService.Delete(CorreoElectronico);

        return Ok(result);

    }


    /// <summary>
    /// It creates a usuario
    /// </summary>
    /// <param name="baseUsuario">the created usuario <see cref="BaseUsuarioDTO"/></param>
    /// <returns>Returns the created usuario <see cref="UsuarioDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    public ActionResult<UsuarioDTO> Post([FromBody] BaseUsuarioDTO baseUsuario)
    {

        return Ok(_usuarioService.Add(baseUsuario));
    }

    /// <summary>
    /// it modifies a usuario
    /// </summary>
    /// <param name="baseUsuario">the created usuario <see cref="BaseUsuarioDTO"/></param>
    /// <param name="CorreoElectronico">the email of the modified usuario</param>
    /// <returns>Returns the modified usuario <see cref="UsuarioDTO"/></returns>
    [HttpPut("{CorreoElectronico}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UsuarioDTO))]
    public ActionResult<UsuarioDTO> Put([FromBody] BaseUsuarioDTO baseUsuario, string CorreoElectronico)
    {

        return Ok(_usuarioService.Modify(baseUsuario, CorreoElectronico));
    }

}
