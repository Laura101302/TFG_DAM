using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PMayoristasController : ControllerBase
{
    private readonly ILogger<PMayoristasController> _logger;
    private readonly IPMayoristaService _pmayoristaService;

    /// <summary>
    /// Crea pmayoristaController
    /// </summary>
    /// <param name="logger">Loggin</param>
    /// <param name="pmayoristaService">Tratado de Data</param>
    public PMayoristasController(ILogger<PMayoristasController> logger, IPMayoristaService pmayoristaService)
    {
        _logger = logger;
        _pmayoristaService = pmayoristaService;
    }

    /// <summary>
    /// Devuelve todos los pmayoristas
    /// </summary>
    /// <returns>Devuelve una lista <see cref="PMayoristaDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    public ActionResult<PMayoristaDTO> Get()
    {
        return Ok(_pmayoristaService.GetAll());
    }

    /// <summary>
    /// Devuelve un pmayorista por el id 
    /// </summary>
    /// <param name="ID">el id del pmayorista</param>
    /// <returns>Devuelve un pmayorista <see cref="PMayoristaDTO"/></returns>
    [HttpGet("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PMayoristaDTO> Get(int ID)
    {
        PMayoristaDTO result = _pmayoristaService.GetByID(ID);

        if (result == null)
            return NotFound();

        return Ok(result);

    }

    /// <summary>
    /// Borra un pmayorista
    /// </summary>
    /// <param name="ID">El id del pmayorista que se va a borrar</param>
    /// <returns>Devuelve el pmayorista borrado <see cref="PMayoristaDTO"/></returns>
    [HttpDelete("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PMayoristaDTO> Delete(int ID)
    {
        PMayoristaDTO result = _pmayoristaService.GetByID(ID);

        if (result == null)
            return NotFound();

        _pmayoristaService.Delete(ID);

        return Ok(result);

    }


    /// <summary>
    /// Crea un pmayorista
    /// </summary>
    /// <param name="basePMayorista">El pmayorista creado <see cref="BasePMayoristaDTO"/></param>
    /// <returns>Deuelve el pmayorista creado <see cref="PMayoristaDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    public ActionResult<PMayoristaDTO> Post([FromBody] BasePMayoristaDTO basePMayorista)
    {

        return Ok(_pmayoristaService.Add(basePMayorista));
    }

    /// <summary>
    /// Modifica un pmayorista
    /// </summary>
    /// <param name="basePMayorista">El pmayorista modificado <see cref="BasePMayoristaDTO"/></param>
    /// <param name="ID">El id del pmayorista modificado</param>
    /// <returns>Devuelve el pmayorista modificado <see cref="PMayoristaDTO"/></returns>
    [HttpPut("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    public ActionResult<PMayoristaDTO> Put([FromBody] BasePMayoristaDTO basePMayorista, int ID)
    {

        return Ok(_pmayoristaService.Modify(basePMayorista, ID));
    }

}
