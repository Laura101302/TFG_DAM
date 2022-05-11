using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OpinionesController : ControllerBase
{
    private readonly ILogger<OpinionesController> _logger;
    private readonly IOpinionService _opinionService;

    /// <summary>
    /// Crea OpinionesController
    /// </summary>
    /// <param name="logger">Loggin</param>
    /// <param name="opinionService">Tratado de Data</param>
    public OpinionesController(ILogger<OpinionesController> logger, IOpinionService opinionService)
    {
        _logger = logger;
        _opinionService = opinionService;
    }

    /// <summary>
    /// Devuelve todas las opiniones
    /// </summary>
    /// <returns>Devuelve una lista <see cref="OpinionDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    public ActionResult<OpinionDTO> Get()
    {
        return Ok(_opinionService.GetAll());
    }

    /// <summary>
    /// Devuelve una opinion por el email
    /// </summary>
    /// <param name="ID">El email de la opinion</param>
    /// <returns>Devuelve una opinion <see cref="OpinionDTO"/></returns>
    [HttpGet("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<OpinionDTO> Get(int ID)
    {
        OpinionDTO result = _opinionService.GetByID(ID);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    /// <summary>
    /// Borra una opinion
    /// </summary>
    /// <param name="ID">El email de la opinion que se va a borrar</param>
    /// <returns>Devuelve la opinion borrada <see cref="OpinionDTO"/></returns>
    [HttpDelete("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<OpinionDTO> Delete(int ID)
    {
        OpinionDTO result = _opinionService.GetByID(ID);

        if (result == null)
            return NotFound();

        _opinionService.Delete(ID);

        return Ok(result);

    }


    /// <summary>
    /// Crea una opinion
    /// </summary>
    /// <param name="baseOpinion">La opinion creada <see cref="BaseOpinionDTO"/></param>
    /// <returns>Devuelve la opinion creada <see cref="OpinionDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    public ActionResult<OpinionDTO> Post([FromBody] BaseOpinionDTO baseOpinion)
    {

        return Ok(_opinionService.Add(baseOpinion));
    }

    /// <summary>
    /// Modifica una opinion
    /// </summary>
    /// <param name="baseOpinion">La opinion modificada <see cref="BaseOpinionDTO"/></param>
    /// <param name="ID">El email de la opinion modificada</param>
    /// <returns>Devuelve la opinion modificada <see cref="OpinionDTO"/></returns>
    [HttpPut("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    public ActionResult<OpinionDTO> Put([FromBody] BaseOpinionDTO baseOpinion, int ID)
    {

        return Ok(_opinionService.Modify(baseOpinion, ID));
    }

}
