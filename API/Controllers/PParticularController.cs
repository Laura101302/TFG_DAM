using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PParticularesController : ControllerBase
{
    private readonly ILogger<PParticularesController> _logger;
    private readonly IPParticularService _pparticularService;

    /// <summary>
    /// Crea PParticularController
    /// </summary>
    /// <param name="logger">Loggin</param>
    /// <param name="pparticularService">Tratado de Data</param>
    public PParticularesController(ILogger<PParticularesController> logger, IPParticularService pparticularService)
    {
        _logger = logger;
        _pparticularService = pparticularService;
    }

    /// <summary>
    /// Devuelve todos los productos de particulares
    /// </summary>
    /// <returns>Devuelve una lista <see cref="PParticularDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    public ActionResult<PParticularDTO> Get()
    {
        return Ok(_pparticularService.GetAll());
    }

    /// <summary>
    /// Devuelve un producto de particular por el id 
    /// </summary>
    /// <param name="ID">El id del producto de particular</param>
    /// <returns>Devuelve un producto de particular <see cref="PParticularDTO"/></returns>
    [HttpGet("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PParticularDTO> Get(int ID)
    {
        PParticularDTO result = _pparticularService.GetByID(ID);

        if (result == null)
            return NotFound();

        return Ok(result);

    }

    /// <summary>
    /// Borra un producto de particular
    /// </summary>
    /// <param name="ID">El id del producto de particular que se va a borrar</param>
    /// <returns>Devuelve el producto de particular borrado <see cref="PParticularDTO"/></returns>
    [HttpDelete("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PParticularDTO> Delete(int ID)
    {
        PParticularDTO result = _pparticularService.GetByID(ID);

        if (result == null)
            return NotFound();

        _pparticularService.Delete(ID);

        return Ok(result);

    }


    /// <summary>
    /// Crea un producto de particular
    /// </summary>
    /// <param name="basePParticular">El producto de particular creado <see cref="BasePParticularDTO"/></param>
    /// <returns>Devuelve el producto de particular creado <see cref="PParticularDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    public ActionResult<PParticularDTO> Post([FromBody] BasePParticularDTO basePParticular)
    {

        return Ok(_pparticularService.Add(basePParticular));
    }

    /// <summary>
    /// Modifica un producto de particular
    /// </summary>
    /// <param name="basePParticular">El producto de particular modificado <see cref="BasePParticularDTO"/></param>
    /// <param name="ID">El id del producto de particular modificado</param>
    /// <returns>Devuelve el producto de particular modificado <see cref="PParticularDTO"/></returns>
    [HttpPut("{ID}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PParticularDTO))]
    public ActionResult<PParticularDTO> Put([FromBody] BasePParticularDTO basePParticular, int ID)
    {

        return Ok(_pparticularService.Modify(basePParticular, ID));
    }

}
