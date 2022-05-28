using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class VParticularesController : ControllerBase
{
    private readonly ILogger<VParticularesController> _logger;
    private readonly IVParticularService _vparticularService;

    /// <summary>
    /// Crea vparticularController
    /// </summary>
    /// <param name="logger">Loggin</param>
    /// <param name="vparticularService">Tratado de Data</param>
    public VParticularesController(ILogger<VParticularesController> logger, IVParticularService vparticularService)
    {
        _logger = logger;
        _vparticularService = vparticularService;
    }

    /// <summary>
    /// Devuelve todos los vparticulars
    /// </summary>
    /// <returns>Devuelve una lista <see cref="VParticularDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    public ActionResult<VParticularDTO> Get()
    {
        return Ok(_vparticularService.GetAll());
    }

    /// <summary>
    /// Devuelve un vparticular por el id 
    /// </summary>
    /// <param name="ID">El id del vparticular</param>
    /// <returns>Devuelve un vparticular <see cref="VParticularDTO"/></returns>
    [HttpGet("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<VParticularDTO> Get(int ID)
    {
        VParticularDTO result = _vparticularService.GetByID(ID);

        if (result == null)
            return NotFound();

        return Ok(result);

    }

    /// <summary>
    /// Borra un vparticular
    /// </summary>
    /// <param name="ID">El id del vparticular que se va a borrar</param>
    /// <returns>Devuelve el vparticular borrado <see cref="VParticularDTO"/></returns>
    [HttpDelete("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<VParticularDTO> Delete(int ID)
    {
        VParticularDTO result = _vparticularService.GetByID(ID);

        if (result == null)
            return NotFound();

        _vparticularService.Delete(ID);

        return Ok(result);

    }


    /// <summary>
    /// Crea un vparticular
    /// </summary>
    /// <param name="baseVParticular">El vparticular creado <see cref="BaseVParticularDTO"/></param>
    /// <returns>Devuelve el vparticular creado <see cref="VParticularDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    public ActionResult<VParticularDTO> Post([FromBody] BaseVParticularDTO baseVParticular)
    {

        return Ok(_vparticularService.Add(baseVParticular));
    }

    /// <summary>
    /// Modifica un vparticular
    /// </summary>
    /// <param name="baseVParticular">El vparticular modificado <see cref="BaseVParticularDTO"/></param>
    /// <param name="ID">El id del vparticular modificado</param>
    /// <returns>Devuelve el vparticular modificado <see cref="VParticularDTO"/></returns>
    [HttpPut("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(VParticularDTO))]
    public ActionResult<VParticularDTO> Put([FromBody] BaseVParticularDTO baseVParticular, int ID)
    {

        return Ok(_vparticularService.Modify(baseVParticular, ID));
    }

}
