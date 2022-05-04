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
    /// It creates a pmayoristaController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="pmayoristaService">used for dealing with the pmayorista data</param>
    public PMayoristasController(ILogger<PMayoristasController> logger, IPMayoristaService pmayoristaService)
    {
        _logger = logger;
        _pmayoristaService = pmayoristaService;
    }

    /// <summary>
    /// Returns all the pmayoristas
    /// </summary>
    /// <returns>Returns a list of <see cref="PMayoristaDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    public ActionResult<PMayoristaDTO> Get()
    {
        return Ok(_pmayoristaService.GetAll());
    }

    /// <summary>
    /// It returns a pmayorista by id 
    /// </summary>
    /// <param name="ID">the id of the pmayorista</param>
    /// <returns>Returns a pmayorista <see cref="PMayoristaDTO"/></returns>
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
    /// it deletes a pmayorista
    /// </summary>
    /// <param name="ID">the id of the pmayorista that is going to be deleted</param>
    /// <returns>Returns the deleted pmayorista <see cref="PMayoristaDTO"/></returns>
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
    /// It creates a pmayorista
    /// </summary>
    /// <param name="basePMayorista">the created pmayorista <see cref="BasePMayoristaDTO"/></param>
    /// <returns>Returns the created pmayorista <see cref="PMayoristaDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    public ActionResult<PMayoristaDTO> Post([FromBody] BasePMayoristaDTO basePMayorista)
    {

        return Ok(_pmayoristaService.Add(basePMayorista));
    }

    /// <summary>
    /// it modifies a pmayorista
    /// </summary>
    /// <param name="basePMayorista">the created pmayorista <see cref="BasePMayoristaDTO"/></param>
    /// <param name="ID">the id of the modified pmayorista</param>
    /// <returns>Returns the modified pmayorista <see cref="PMayoristaDTO"/></returns>
    [HttpPut("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PMayoristaDTO))]
    public ActionResult<PMayoristaDTO> Put([FromBody] BasePMayoristaDTO basePMayorista, int ID)
    {

        return Ok(_pmayoristaService.Modify(basePMayorista, ID));
    }

}
